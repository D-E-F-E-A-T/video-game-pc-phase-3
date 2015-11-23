#pragma once
#include "World.h"

class WorldFactory
{
public:
	World * Build(
		float2 fScreenDimensions,
		const shared_ptr<DeviceResources>& deviceResources);

protected:

private:
};


