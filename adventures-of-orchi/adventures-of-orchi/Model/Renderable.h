#pragma once
#include "pch.h"
#include "..\Common\DeviceResources.h"

using namespace Microsoft::WRL;
using namespace std;

class Renderable
{
public:
	Renderable(const shared_ptr<DeviceResources>& deviceResources)
	{
		m_deviceResources = deviceResources;
	}

	// Consider using this when doing 3D.
	virtual void Update() {}

	virtual void Render(
		ComPtr<ID3D11RenderTargetView> renderTargetView,
		float2 fLocationRatio,
		float fRotationInRadians,
		float2 fWindowDimensions,
		float2 fScaleDimensions,
		float dpi) = 0;

	float * GetBounds();
	float2 GetDimensionsRatio() { return m_fDimensions; }

	virtual uint8_t * GetPixels() { return nullptr; }

	virtual int * GetTextureDimensions() { return nullptr; }


protected:
	// This must not have location. That is part of Space.

	float * m_pfBounds;
	float2 m_fDimensionsRatio;
	shared_ptr<DeviceResources> m_deviceResources;
	float2 m_fDimensions;	
private:

};
