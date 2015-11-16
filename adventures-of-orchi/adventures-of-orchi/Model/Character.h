#pragma once
#include "Movable.h"

using namespace Platform;

class Character : public Movable
{
public:
	Character(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources)
		: Movable(
			pfLocationRatio,
			pfDimensions,
			true,
			deviceResources)
	{

	}

protected:

private:
};