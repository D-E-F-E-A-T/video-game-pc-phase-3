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

