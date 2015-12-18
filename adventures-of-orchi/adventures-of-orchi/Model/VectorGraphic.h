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
#include "..\Constants.h"
#include "Renderable2D.h"
#include "..\Common\DeviceResources.h"
#include "Wireframe.h"
 
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
			m_deviceResources->m_mapBrushes["red"]);
#endif // RENDER_DIAGNOSTICS
	}

protected:
	Wireframe * m_pWireframe;

private:
};
