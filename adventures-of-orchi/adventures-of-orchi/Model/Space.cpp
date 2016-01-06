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
	float2 fDimensionsRatio,
	bool bIsVisible,
	bool bIsActionable,
	bool bIsCollidable,
	ServiceProxy::BuildCommand ^ pCommand,
	const shared_ptr<DeviceResources>& deviceResources)
{
	m_deviceResources = deviceResources;
	m_fLocationRatio = fLocationRatio;

	m_bIsVisible = bIsVisible;
	m_bIsActionable = bIsActionable;
	m_bIsCollidable = bIsCollidable;
	m_fRotationInRadians = fRotationInRadians;

	m_fDimensionsRatio = fDimensionsRatio;

	m_pCommand = pCommand;
}

Space::~Space()
{
	delete m_pRenderable;

}

float2 Space::GetLocationRatio()
{
	return m_fLocationRatio;
}

float2 Space::GetDimensionsRatio()
{
	return m_fDimensionsRatio;
}

float Space::CalculateDistance(Space * space)
{
	return Utils::CalculateDistance(
		m_fLocationRatio, 
		space->GetLocationRatio());
}

float Space::CalculateDistance(Space * pOther, XMFLOAT3 * vec3Differential)
{
	XMVECTOR vecLocation = 
		XMVectorSet(
			pOther->GetLocationRatio().x,
			pOther->GetLocationRatio().y,
			0.0f,
			0.0f);

	XMVECTOR vecDifferential = XMLoadFloat3(vec3Differential);

	XMVECTOR vecResultant = vecLocation + vecDifferential;

	float2 fResultant
	{ 
		XMVectorGetX(vecResultant),
		XMVectorGetY(vecResultant)
	};

	return Utils::CalculateDistance(
		m_fLocationRatio,
		fResultant);

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
			m_fDimensionsRatio, // Dimensions of the bounding box for a wireframe.
			fWindowDimensions,
			fScaleDimensions,	// Dimensions of the bounding box for a texture.
			dpi);
	}
}