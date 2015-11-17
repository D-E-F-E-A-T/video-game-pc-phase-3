#pragma once
#include "Space.h"

using namespace Platform;

class Movable : public Space
{
public:
	Movable(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources)
		: Space(
			pfLocationRatio,
			fRotationInRadians,
			true,
			false,
			true,
			deviceResources)
	{

	}

protected:

private:

};