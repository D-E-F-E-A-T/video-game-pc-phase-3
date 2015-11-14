#pragma once
#include "Space.h"

using namespace Platform;

class Immovable : public Space
{
public:
	Immovable(
		String ^ strTextureName,
		float2 pfLocationRatio,
		float2 pfDimensionRatio,
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		const shared_ptr<DeviceResources>& deviceResources)
		: Space(
			strTextureName,
			pfLocationRatio,
			pfDimensionRatio,
			bIsVisible,
			bIsActionable,
			bIsCollidable,
			deviceResources)
	{

	}

protected:

private:
};
