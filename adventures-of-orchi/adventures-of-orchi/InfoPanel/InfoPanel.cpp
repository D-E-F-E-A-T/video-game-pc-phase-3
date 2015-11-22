#include "pch.h"
#include "InfoPanel.h"

void InfoPanel::CreateText(String ^ text, float2 fWindowSize, const shared_ptr<DeviceResources>& deviceResources)
{
	D2D1_SIZE_F size = deviceResources->GetD2DDeviceContext()->GetSize();
	size.height = fWindowSize.y / 3.0f;
	size.width = fWindowSize.x * LEFT_MARGIN_RATIO;

	ComPtr<IDWriteTextLayout> textLayout;

	DX::ThrowIfFailed(
		deviceResources->m_dwriteFactory->CreateTextLayout(
			text->Data(),
			text->Length(),
			deviceResources->m_textFormat.Get(),
			size.width,
			size.height,
			&textLayout
			)
		);

	textLayout.As(&m_textLayout);

	m_textRange.startPosition = 0;
	m_textRange.length = text->Length();
	m_textLayout->SetFontSize(SECTION_HEADER_FONT_SIZE, m_textRange);
	m_textLayout->SetCharacterSpacing(0.5f, 0.5f, 0, m_textRange);
	m_textLayout->SetTextAlignment(DWRITE_TEXT_ALIGNMENT_CENTER);
}

void InfoPanel::DrawText(float fLeft, float fTop, float fRight, const shared_ptr<DeviceResources>& deviceResources)
{
	deviceResources->GetD2DDeviceContext()->DrawTextLayout(
		D2D1::Point2F(fLeft, fTop),
		m_textLayout.Get(),
		deviceResources->m_whiteBrush.Get()
		);
}

void InfoPanel::DrawBox(float fLeft, float fTop, float fRight, float fBottom, const shared_ptr<DeviceResources>& deviceResources)
{
	D2D1_RECT_F rect{ fLeft, fTop, fRight, fBottom };

	deviceResources->GetD2DDeviceContext()->DrawRectangle(
		rect,
		deviceResources->m_whiteBrush.Get());
}