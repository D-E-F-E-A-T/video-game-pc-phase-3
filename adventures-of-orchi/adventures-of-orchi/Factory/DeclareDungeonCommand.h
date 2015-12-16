/*
Copyright 2016 Richard Bernardino

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
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
