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
#include "..\Constants.h"
#include "Texture.h"


map<ID3D11Texture2D *, uint8_t *> Texture::m_pixelMap;

Texture::Texture(
	String ^ strTextureName,
	const shared_ptr<DeviceResources>& deviceResources)
	: Renderable2D(deviceResources, nullptr)
{
	// Consider that not all spaces are Sprites!!
	if (strTextureName != nullptr)
	{
		m_spriteBatch = ref new BasicSprites::SpriteBatch();

		m_spriteBatch->Initialize(
			m_deviceResources->GetD3DDevice(),
			1);

		BasicLoader ^ loader =
			ref new BasicLoader(
				m_deviceResources->GetD3DDevice(),
				m_deviceResources->GetWicImagingFactory());

		// Use flyweight pattern to avoid loading this for every tree.
		loader->LoadTexture(
			strTextureName,
			&m_pTexture,
			nullptr);

		m_spriteBatch->AddTexture(m_pTexture.Get());

		m_pixelMap[m_pTexture.Get()] = SpriteUtils::ReadPixels(
			DEVICE_CONTEXT_3D,
			DEVICE_3D,
			m_pTexture.Get(),
			m_pTextureDimensions);
	}
}

void Texture::Render(
	ComPtr<ID3D11RenderTargetView> renderTargetView,
	float2 fLocationRatio,
	float fRotationInRadians,
	float2 fWindowDimensions,
	float2 fScaleDimensions,
	float dpi)
{
	m_spriteBatch->Begin(renderTargetView.Get(), dpi);

	float2 fPosition =
		fLocationRatio * float2(fWindowDimensions.x, fWindowDimensions.y);

	m_spriteBatch->Draw(
		m_pTexture.Get(),
		fPosition,
		BasicSprites::PositionUnits::DIPs,
		fScaleDimensions * TEXTURE_SCALE_FACTOR,
		BasicSprites::SizeUnits::DIPs,
		float4(0.8f, 0.8f, 1.0f, 1.0f),
		fRotationInRadians);

	m_spriteBatch->End();
}




