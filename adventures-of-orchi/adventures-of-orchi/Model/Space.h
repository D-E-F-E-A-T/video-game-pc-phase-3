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
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		const shared_ptr<DeviceResources>& deviceResources);

	~Space();

	virtual float2 GetLocationRatio(); // virtual because of Sword.

	virtual float CalculateDistance(Space * space);

	vector<Space *> DetectCollisions() {}

	void Render(
		ComPtr<ID3D11RenderTargetView> renderTargetView,
		float2 fWindowDimensions,
		float2 fScaleDimensions,
		float dpi);

	uint8_t * GetPixels()
	{
		return m_pRenderable->GetPixels();
	}

	int * GetTextureDimensions()
	{
		return m_pRenderable->GetTextureDimensions();
	}

protected:
	Renderable * m_pRenderable;
	float2 m_fLocationRatio;
	bool m_bIsVisible;
	bool m_bIsActionable;
	bool m_bIsCollidable;

	shared_ptr<DeviceResources> m_deviceResources;

private:

};