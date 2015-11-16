#pragma once
#include "Thing.h"
#include "Texture.h"

class Water : public Thing
{
public:
	Water(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources) :
		Thing(
			pfLocationRatio,
			pfDimensions,
			true,
			false,
			true,
			deviceResources)
	{
		m_pRenderable = new Texture("water.dds", deviceResources);
	}

protected:

private:
};