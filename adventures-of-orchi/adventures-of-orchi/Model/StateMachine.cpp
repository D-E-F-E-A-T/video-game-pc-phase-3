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
	m_nCurrentStateId = 0;
	pCurrentSubdivision = nullptr;

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
	m_buildCommands[APPLY_OVERLAY_COMMAND] = new ApplyOverlayCommand();
}

StateMachine::~StateMachine()
{
	for (int i = 0; i < NUM_BUILD_COMMANDS; i++)
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

	for each (ServiceProxy::BuildCommand ^ command in commands)
	{
		for (int i = 0; i < NUM_BUILD_COMMANDS; i++)
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
#ifdef _DEBUG_STATE_MACHINE
	char buffer[64];
	sprintf_s(buffer, "StateMachine: m_nCurrentStateId %d\n", m_nCurrentStateId);
	OutputDebugStringA(buffer);
#endif // _DEBUG_STATE_MACHINE

	// TODO: Use function pointers.		
	if (m_nCurrentStateId == 0)
	{
#ifdef _DEBUG_STATE_MACHINE
		OutputDebugStringA("DoState0\n");
#endif // _DEBUG_STATE_MACHINE

		m_nCurrentStateId = DoState0(
			nCommandType,
			retVal,
			fScreenDimensions,
			command,
			pCurrentSubdivision,
			deviceResources);
	}
	else if (m_nCurrentStateId == 1)
	{
#ifdef _DEBUG_STATE_MACHINE
		OutputDebugStringA("DoState1\n");
#endif // _DEBUG_STATE_MACHINE

		m_nCurrentStateId = DoState1(
			nCommandType,
			retVal,
			fScreenDimensions,
			command,
			pCurrentSubdivision,
			deviceResources);
	}
	

}

int StateMachine::DoState0(
	int nCommandType,
	World ** retVal,
	float2 fScreenDimensions,
	ServiceProxy::BuildCommand ^ command,
	Subdivision ** pCurrentSubdivision,
	const shared_ptr<DeviceResources>& deviceResources)
{
	int nNextState = 0;

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
		case DECLARE_CAVE_COMMAND:
		case DECLARE_DUNGEON_COMMAND:
		case DECLARE_LAND_COMMAND:
		case DECLARE_LOT_COMMAND:
		case DECLARE_WORLD_COMMAND:
		case ADD_BORDER_COMMAND:
		case APPLY_OVERLAY_COMMAND:
		{
			m_buildCommands[nCommandType]->Process(
				retVal,
				fScreenDimensions,
				command,
				pCurrentSubdivision,
				deviceResources);

			// Note: pCurrentSubdivision is set 
			//	normally.

			nNextState = 0;
		}
		break;

		case DECLARE_OVERLAY_COMMAND:
		{
			m_buildCommands[DECLARE_OVERLAY_COMMAND]->Process(
				retVal,
				fScreenDimensions,
				command,
				pCurrentSubdivision,
				deviceResources);

			// Note: pCurrentSubdivision is now set to
			//	a brand new Overlay.

			nNextState = 1;
		}
		break;
	}

	return nNextState;
}

// Declare Overlay for a Subdivision
int StateMachine::DoState1(
	int nCommandType,
	World ** retVal,
	float2 fScreenDimensions,
	ServiceProxy::BuildCommand ^ command,
	Subdivision ** pCurrentSubdivision,
	const shared_ptr<DeviceResources>& deviceResources)
{
	int nNextState = 1;

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
		case ADD_BORDER_COMMAND:
		{
			m_buildCommands[nCommandType]->Process(
				retVal,
				fScreenDimensions,
				command,
				pCurrentSubdivision,
				deviceResources);

			nNextState = 1;
		}
		break;

		case END_OVERLAY_COMMAND:
		{
			m_buildCommands[END_OVERLAY_COMMAND]->Process(
				retVal,
				fScreenDimensions,
				command,
				pCurrentSubdivision,
				deviceResources);

			nNextState = 0;
		}
	}

	return nNextState;
}