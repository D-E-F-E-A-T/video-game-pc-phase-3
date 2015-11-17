#pragma once
#include "Space.h"

using namespace Platform;

class Immovable : public Space
{
public:
	Immovable(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensionRatio,
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		const shared_ptr<DeviceResources>& deviceResources)
		: Space(
			pfLocationRatio,
			fRotationInRadians,
			bIsVisible,
			bIsActionable,
			bIsCollidable,
			deviceResources)
	{

	}

protected:

private:
};