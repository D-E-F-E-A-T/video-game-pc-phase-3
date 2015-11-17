#pragma once
#include "Thing.h"
#include "Texture.h"

class StoneWall : public Thing
{
public:
	StoneWall(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources) :
		Thing(
			pfLocationRatio,
			fRotationInRadians,
			pfDimensions,
			true,
			false,
			true,
			deviceResources)
	{
		m_pRenderable = new Texture("stonewall.dds", deviceResources);
	}

protected:

private:
};