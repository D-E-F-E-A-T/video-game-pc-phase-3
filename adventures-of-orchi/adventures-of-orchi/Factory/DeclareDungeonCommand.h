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
		int id = ((ServiceProxy::DeclareDungeonCommand ^)command)->Id;

		int columns = ((ServiceProxy::DeclareDungeonCommand ^)command)->Columns;
		int rows = ((ServiceProxy::DeclareDungeonCommand ^)command)->Rows;

		int entryX = ((ServiceProxy::DeclareDungeonCommand ^)command)->EntryX;
		int entryY = ((ServiceProxy::DeclareDungeonCommand ^)command)->EntryY;

		(*pWorld)->AddRegion(new Dungeon(id, columns, rows, entryX, entryY));
	}

protected:

private:
};
