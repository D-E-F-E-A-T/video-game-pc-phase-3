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
#include "pch.h"
#include "Constants.h"
#include "WorldFactory.h"
#include "..\Model\Land.h"
#include "..\Model\Edge.h"
#include "..\Model\Dungeon.h"
#include "..\Model\Grass.h"
#include "..\Model\Rock.h"
#include "..\Model\Stairs.h"
#include "..\Model\StoneWall.h"
#include "..\Model\Tree.h"
#include "..\Model\Water.h"
#include "..\Utils.h"
#include "AddEdgeCommand.h"
#include "AddForestCommand.h"
#include "AddGrassCommand.h"
#include "AddRockCommand.h"
#include "AddStairsCommand.h"
#include "AddStoneWallCommand.h"
#include "AddTreeCommand.h"
#include "AddWaterCommand.h"
#include "DeclareCaveCommand.h"
#include "DeclareDungeonCommand.h"
#include "DeclareLandCommand.h"
#include "DeclareLotCommand.h"
#include "DeclareWorldCommand.h"
#include "AddBorderCommand.h"

using namespace Windows::Foundation::Collections;
using namespace std;

WorldFactory::WorldFactory()
{
	m_buildCommands[0] = new AddEdgeCommand();
	m_buildCommands[1] = new AddForestCommand();
	m_buildCommands[2] = new AddGrassCommand();
	m_buildCommands[3] = new AddRockCommand();
	m_buildCommands[4] = new AddStairsCommand();
	m_buildCommands[5] = new AddStoneWallCommand();
	m_buildCommands[6] = new AddTreeCommand();
	m_buildCommands[7] = new AddWaterCommand();
	m_buildCommands[8] = new DeclareCaveCommand();
	m_buildCommands[9] = new DeclareDungeonCommand();
	m_buildCommands[10] = new DeclareLandCommand();
	m_buildCommands[11] = new DeclareLotCommand();
	m_buildCommands[12] = new DeclareWorldCommand();
	m_buildCommands[13] = new AddBorderCommand();
}

WorldFactory::~WorldFactory()
{
	for (int i = 0; i < 14; i++)
	{
		delete m_buildCommands[i];
	}
}

World * WorldFactory::Build(float2 fScreenDimensions, const shared_ptr<DeviceResources>& deviceResources)
{
	World * retVal = nullptr;

	ServiceProxy::ServiceProxy ^ proxy = ref new ServiceProxy::ServiceProxy();

	IIterable<ServiceProxy::BuildCommand ^> ^ commands = proxy->Build();

	String ^ strCurrentRegionId;

	Subdivision * pCurrentSubdivision = nullptr;

	for each (ServiceProxy::BuildCommand ^ command in commands)
	{
		for (int i = 0; i < 14; i++)
		{
			if (command->Type == i)
			{
				m_buildCommands[i]->Process(&retVal, fScreenDimensions, command, &pCurrentSubdivision, deviceResources);
			}
		}
	}

	return retVal;
}
