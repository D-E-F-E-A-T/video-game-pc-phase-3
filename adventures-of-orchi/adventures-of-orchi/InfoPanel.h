#pragma once
#include "pch.h"
#include "Constants.h"
#include "Common\DeviceResources.h"
#include "Common\DirectXHelper.h"

using namespace DirectX;
using namespace Microsoft::WRL;
using namespace DX;
using namespace std;
using namespace Platform;

class InfoPanel
{
public:

	void CreateText(String ^ text, float2 fWindowSize, const shared_ptr<DeviceResources>& deviceResources)
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

	virtual void DrawText(const shared_ptr<DeviceResources>& deviceResources) = 0;

protected:

	ComPtr<IDWriteTextLayout1> m_textLayout;
	DWRITE_TEXT_RANGE m_textRange;

private:
};
