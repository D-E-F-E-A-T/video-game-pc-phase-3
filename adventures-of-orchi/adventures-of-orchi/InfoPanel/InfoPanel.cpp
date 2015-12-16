/*
Copyright 2016 Richard Bernardino

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
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
		deviceResources->m_mapBrushes["white"]
		);
}

void InfoPanel::DrawBox(float fLeft, float fTop, float fRight, float fBottom, const shared_ptr<DeviceResources>& deviceResources)
{
	D2D1_RECT_F rect{ fLeft, fTop, fRight, fBottom };

	deviceResources->GetD2DDeviceContext()->DrawRectangle(
		rect,
		deviceResources->m_mapBrushes["white"]);
}