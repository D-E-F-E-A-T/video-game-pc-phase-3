#pragma once
#include "pch.h"
#include "Movable.h"

class Tool : public Movable
{
public:
	Tool(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources)
		: Movable(
			pfLocationRatio,
			pfDimensions,
			bIsVisible,
			deviceResources) {};

protected:

private:
};