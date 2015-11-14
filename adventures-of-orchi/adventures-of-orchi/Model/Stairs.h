#pragma once
#include "pch.h"
#include "Portal.h"
#include "Constants.h"

class Stairs : public Portal
{
public:
	Stairs(
		float2 pfLocationRatio,
		float2 pfDimensionRatio,
		int nDestination,
		const shared_ptr<DeviceResources>& deviceResources) :
		Portal(
			"stairs.dds",
			pfLocationRatio,
			pfDimensionRatio,
			nDestination,
			deviceResources)
	{
	}

protected:

private:

};