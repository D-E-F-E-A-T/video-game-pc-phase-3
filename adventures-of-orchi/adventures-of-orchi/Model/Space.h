#pragma once
#include "pch.h"
#include "..\Constants.h"
#include "..\Common\DeviceResources.h"
#include "Renderable.h"



using namespace BasicSprites;
using namespace std;
using namespace Platform;

class Space
{
public:
	Space() {};

	Space(
		float2 fLocationRatio,
		float fRotationInRadians,
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		const shared_ptr<DeviceResources>& deviceResources);

	~Space();

	float2 GetLocationRatio();
	void SetLocationRatio(float2 fLocationRatio) { m_fLocationRatio = fLocationRatio; }

	virtual float CalculateDistance(Space * space);

	vector<Space *> DetectCollisions() {}

	void Render(
		ComPtr<ID3D11RenderTargetView> renderTargetView,
		float2 fWindowDimensions,
		float2 fScaleDimensions,
		float dpi);

	//virtual Action * Act(World * pWorld)
	//{
	//	return nullptr;
	//}
	// "Rotate" connotes turning away from the 
	//	current angle. 
	void TurnTowards(float fRadians) 
	{ 
		m_fRotationInRadians = fRadians; 
	}

	uint8_t * GetPixels()
	{
		return m_pRenderable->GetPixels();
	}

	int * GetTextureDimensions()
	{
		return m_pRenderable->GetTextureDimensions();
	}

	void SetVisibility(bool bIsVisible) { m_bIsVisible = bIsVisible; }
	bool GetVisibility() { return m_bIsVisible; }

protected:
	Renderable * m_pRenderable;
	float2 m_fLocationRatio;
	float m_fRotationInRadians;
	bool m_bIsVisible;
	bool m_bIsActionable;
	bool m_bIsCollidable;

	shared_ptr<DeviceResources> m_deviceResources;

private:

};