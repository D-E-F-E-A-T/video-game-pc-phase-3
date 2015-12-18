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
#pragma once
#include "pch.h"
#include "Renderable2D.h"
#include "..\Sprites\BasicSprites.h"
#include "..\Sprites\SpriteUtils.h"

using namespace Microsoft::WRL;
using namespace Platform;
using namespace BasicSprites;
using namespace std;

class Texture : public Renderable2D
{
public:
	Texture(
		String ^ strTextureName,
		const shared_ptr<DeviceResources>& deviceResources);

	ID3D11Texture2D * GetTexture() { return m_pTexture.Get(); }

	void Render(
		ComPtr<ID3D11RenderTargetView> renderTargetView,
		float2 fLocationRatio,
		float fRotationInRadians,
		float2 fWindowDimensions,
		float2 fScaleDimensions,
		float dpi);

	uint8_t * GetPixels() 
	{ 
		return m_pixelMap[m_pTexture.Get()]; 
	}

	// Only Valid for sprites.
	int * GetTextureDimensions() { return m_pTextureDimensions; }

	float2 GetSpriteSize()
	{
		return m_spriteBatch->GetSpriteSize(m_pTexture.Get());
	}


protected:
	SpriteBatch ^ m_spriteBatch;

	ID3D11Texture2D * m_pSprite;

	ComPtr<ID3D11Texture2D> m_pTexture;

	uint8_t * m_pPixels;
	int m_pTextureDimensions[2];

	static map<ID3D11Texture2D *, uint8_t *> m_pixelMap;

private:
};

