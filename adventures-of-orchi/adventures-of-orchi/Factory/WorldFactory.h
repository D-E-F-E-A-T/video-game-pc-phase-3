#pragma once
#include "..\Model\World.h"
#include "BuildCommand.h"

class WorldFactory
{
public:
	WorldFactory();
	~WorldFactory();
	World * Build(
		float2 fScreenDimensions,
		const shared_ptr<DeviceResources>& deviceResources);

protected:
	BuildCommand * m_buildCommands[13];

private:
};


