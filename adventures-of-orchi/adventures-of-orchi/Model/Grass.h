#pragma once
#include "Thing.h"

class Grass : public Thing
{
public:
	Grass(
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
		m_pRenderable = new Texture("grass.dds", deviceResources);
	}

protected:

private:
};
