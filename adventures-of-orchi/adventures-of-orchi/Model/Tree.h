#pragma once
#include "Thing.h"
#include "Texture.h"

class Tree : public Thing
{
public:
	Tree(
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
		m_pRenderable = new Texture("tree.dds", deviceResources);
	}

protected:

private:
};