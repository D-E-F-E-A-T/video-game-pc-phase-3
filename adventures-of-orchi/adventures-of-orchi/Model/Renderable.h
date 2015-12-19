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
#include "..\Common\DeviceResources.h"

using namespace Microsoft::WRL;
using namespace std;

class Renderable
{
public:
	Renderable(
		const shared_ptr<DeviceResources>& deviceResources,
		Wireframe * pWireframe)
	{
		m_deviceResources = deviceResources;
		m_pWireframe = pWireframe;
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

//	float * GetBounds();
	//float2 GetDimensionsRatio() { return m_fDimensions; }

	virtual uint8_t * GetPixels() { return nullptr; }

	virtual int * GetTextureDimensions() { return nullptr; }

	//virtual void Transform();


protected:
	// This must not have location. That is part of Space.

	//float * m_pfBounds;
	//float2 m_fDimensionsRatio;
	//float2 m_fDimensions;	
	Wireframe * m_pWireframe;

	shared_ptr<DeviceResources> m_deviceResources;
private:

};
