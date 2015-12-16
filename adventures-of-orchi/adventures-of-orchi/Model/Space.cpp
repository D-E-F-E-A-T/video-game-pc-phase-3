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
#include "Space.h"
#include "..\Utils.h"
#include "..\Sprites\SpriteUtils.h"

using namespace std;
using namespace DirectX;

Space::Space(
	float2 fLocationRatio,
	float fRotationInRadians,
	bool bIsVisible,
	bool bIsActionable,
	bool bIsCollidable,
	const shared_ptr<DeviceResources>& deviceResources)
{
	m_deviceResources = deviceResources;
	m_fLocationRatio = fLocationRatio;

	m_bIsVisible = bIsVisible;
	m_bIsActionable = bIsActionable;
	m_bIsCollidable = bIsCollidable;
	m_fRotationInRadians = fRotationInRadians;
}

Space::~Space()
{
	delete m_pRenderable;

}

float2 Space::GetLocationRatio()
{
	return m_fLocationRatio;
}

float Space::CalculateDistance(Space * space)
{
	return Utils::CalculateDistance(
		m_fLocationRatio, 
		space->GetLocationRatio());
}

void Space::Render(
	ComPtr<ID3D11RenderTargetView> renderTargetView,
	float2 fWindowDimensions,
	float2 fScaleDimensions,
	float dpi)
{
	if (m_bIsVisible)
	{
		m_pRenderable->Render(
			renderTargetView,
			m_fLocationRatio,
			m_fRotationInRadians,
			fWindowDimensions,
			fScaleDimensions,
			dpi);
	}
}