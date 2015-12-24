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
#include "StateMachine.h"
#include "..\Model\World.h"

using namespace Windows::Foundation::Collections;
using namespace std;

StateMachine::StateMachine()
{
	m_nStateId = 0;

	m_buildCommands[ADD_EDGE_COMMAND] = new AddEdgeCommand();
	m_buildCommands[ADD_FOREST_COMMAND] = new AddForestCommand();
	m_buildCommands[ADD_GRASS_COMMAND] = new AddGrassCommand();
	m_buildCommands[ADD_ROCK_COMMAND] = new AddRockCommand();
	m_buildCommands[ADD_STAIRS_COMMAND] = new AddStairsCommand();
	m_buildCommands[ADD_STONEWALL_COMMAND] = new AddStoneWallCommand();
	m_buildCommands[ADD_TREE_COMMAND] = new AddTreeCommand();
	m_buildCommands[ADD_WATER_COMMAND] = new AddWaterCommand();
	m_buildCommands[DECLARE_CAVE_COMMAND] = new DeclareCaveCommand();
	m_buildCommands[DECLARE_DUNGEON_COMMAND] = new DeclareDungeonCommand();
	m_buildCommands[DECLARE_LAND_COMMAND] = new DeclareLandCommand();
	m_buildCommands[DECLARE_LOT_COMMAND] = new DeclareLotCommand();
	m_buildCommands[DECLARE_WORLD_COMMAND] = new DeclareWorldCommand();
	m_buildCommands[ADD_BORDER_COMMAND] = new AddBorderCommand();
	m_buildCommands[DECLARE_OVERLAY_COMMAND] = new DeclareOverlayCommand();
	m_buildCommands[END_OVERLAY_COMMAND] = new EndOverlayCommand();
}

StateMachine::~StateMachine()
{
	for (int i = 0; i < 16; i++)
	{
		delete m_buildCommands[i];
	}
}

World * StateMachine::Process(
	float2 fScreenDimensions, 
	const shared_ptr<DeviceResources>& deviceResources)
{
	World * retVal = nullptr;

	ServiceProxy::ServiceProxy ^ proxy = ref new ServiceProxy::ServiceProxy();

	IIterable<ServiceProxy::BuildCommand ^> ^ commands = proxy->Build();

	String ^ strCurrentRegionId;

	Subdivision * pCurrentSubdivision = nullptr;

	for each (ServiceProxy::BuildCommand ^ command in commands)
	{
		for (int i = 0; i < 16; i++)
		{
			if (command->Type == i)
			{
				Move(
					i,
					&retVal,
					fScreenDimensions,
					command,
					&pCurrentSubdivision,
					deviceResources);				
			}
		}
	}

	return retVal;
}

void StateMachine::Move(
	int nCommandType,
	World ** retVal,
	float2 fScreenDimensions,
	ServiceProxy::BuildCommand ^ command,
	Subdivision ** pCurrentSubdivision,
	const shared_ptr<DeviceResources>& deviceResources)
{
	// TODO: Use function pointers.
	if (m_nStateId == 0)
	{
		DoState0(
			nCommandType,
			retVal,
			fScreenDimensions,
			command,
			pCurrentSubdivision,
			deviceResources);
	}

}

void StateMachine::DoState0(
	int nCommandType,
	World ** retVal,
	float2 fScreenDimensions,
	ServiceProxy::BuildCommand ^ command,
	Subdivision ** pCurrentSubdivision,
	const shared_ptr<DeviceResources>& deviceResources)
{
	switch (nCommandType)
	{
	case ADD_EDGE_COMMAND:
	case ADD_FOREST_COMMAND:
	case ADD_GRASS_COMMAND:
	case ADD_ROCK_COMMAND:
	case ADD_STAIRS_COMMAND:
	case ADD_STONEWALL_COMMAND:
	case ADD_TREE_COMMAND:
	case ADD_WATER_COMMAND:
	case ADD_CAVE_COMMAND:
	case DECLARE_DUNGEON_COMMAND:
	case DECLARE_LAND_COMMAND:
	case DECLARE_LOT_COMMAND:
	case DECLARE_WORLD_COMMAND:
	case ADD_BORDER_COMMAND:
		m_buildCommands[nCommandType]->Process(
			retVal, 
			fScreenDimensions, 
			command, 
			pCurrentSubdivision, 
			deviceResources);
		break;

	case DECLARE_OVERLAY_COMMAND:
		m_buildCommands[DECLARE_OVERLAY_COMMAND]->Process(
			retVal,
			fScreenDimensions,
			command,
			pCurrentSubdivision,
			deviceResources);
		break;

	case END_OVERLAY_COMMAND:
		m_buildCommands[END_OVERLAY_COMMAND]->Process(
			retVal,
			fScreenDimensions,
			command,
			pCurrentSubdivision,
			deviceResources);
		break;
	}
}

void StateMachine::DoState1(
	int nCommandType,
	World ** retVal,
	float2 fScreenDimensions,
	ServiceProxy::BuildCommand ^ command,
	Subdivision ** pCurrentSubdivision,
	const shared_ptr<DeviceResources>& deviceResources)
{
	m_buildCommands[nCommandType]->Process(
		retVal,
		fScreenDimensions,
		command,
		pCurrentSubdivision,
		deviceResources);
}

void StateMachine::DoState2(
	int nCommandType,
	World ** retVal,
	float2 fScreenDimensions,
	ServiceProxy::BuildCommand ^ command,
	Subdivision ** pCurrentSubdivision,
	const shared_ptr<DeviceResources>& deviceResources)
{
	m_buildCommands[nCommandType]->Process(
		retVal,
		fScreenDimensions,
		command,
		pCurrentSubdivision,
		deviceResources);
}