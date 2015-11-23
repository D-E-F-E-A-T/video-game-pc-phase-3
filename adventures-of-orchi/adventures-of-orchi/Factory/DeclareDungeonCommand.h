#pragma once
#include "BuildCommand.h"
#include "..\Model\Dungeon.h"
#include "..\Utils.h"
#include "..\Model\Region.h"
#include "..\Model\World.h"

class DeclareDungeonCommand : public BuildCommand
{
public:
	void Process(
		World ** pWorld,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pSubdivision,
		const shared_ptr<DeviceResources>& deviceResources)
	{
		String ^ strName = ((ServiceProxy::DeclareDungeonCommand ^)command)->Name;
		int x = ((ServiceProxy::DeclareDungeonCommand ^)command)->X;
		int y = ((ServiceProxy::DeclareDungeonCommand ^)command)->Y;

		(*pWorld)->AddRegion(new Dungeon(strName, x, y));
	}

protected:

private:
};
