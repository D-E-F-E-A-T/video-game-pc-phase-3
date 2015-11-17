#pragma once
#include "Movable.h"

using namespace Platform;

class Character : public Movable
{
public:
	Character(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources)
		: Movable(
			pfLocationRatio,
			fRotationInRadians,
			pfDimensions,
			true,
			deviceResources)
	{

	}

protected:

private:
};