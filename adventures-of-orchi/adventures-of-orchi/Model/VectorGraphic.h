#pragma once
#include "pch.h"
#include "..\Constants.h"
#include "Renderable2D.h"
#include "..\Common\DeviceResources.h"
 
using namespace Microsoft::WRL;

class VectorGraphic : public Renderable2D
{
public:

	VectorGraphic(
		const shared_ptr<DeviceResources>& deviceResources)
		: Renderable2D(deviceResources)
	{
	}

	void Render(
		ComPtr<ID3D11RenderTargetView> renderTargetView,
		float2  fLocationRatio,
		float fRotationInRadians,
		float2 fWindowDimensions,
		float2 fScaleDimensions,
		float dpi)
	{
#ifdef RENDER_DIAGNOSTICS
		float2 fScreenLocation = fLocationRatio * fWindowDimensions;

		D2D1_RECT_F rect
		{
			fScreenLocation.x - (fWindowDimensions.x / 100.f),
			fScreenLocation.y - (fWindowDimensions.y / 100.f),
			fScreenLocation.x + (fWindowDimensions.x / 100.f),
			fScreenLocation.y + (fWindowDimensions.y / 100.f)
		};

		DEVICE_CONTEXT_2D->FillRectangle(
			rect,
			m_deviceResources->m_mapBrushes["black"]);
#endif // RENDER_DIAGNOSTICS
	}

protected:

private:
};
