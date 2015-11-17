#include "pch.h"
#include "Space.h"
#include "..\MathUtils.h"
#include "..\Sprites\SpriteUtils.h"


using namespace std;


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
	return MathUtils::CalculateDistance(
		m_fLocationRatio, 
		space->GetLocationRatio());
}

void Space::Render(
	ComPtr<ID3D11RenderTargetView> renderTargetView,
	float2 fWindowDimensions,
	float2 fScaleDimensions,
	float dpi)
{
	m_pRenderable->Render(
		renderTargetView, 
		GetLocationRatio(),
		fWindowDimensions, 
		fScaleDimensions, 
		dpi);
}