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
#include "pch.h"
#include "..\Factory\BuildCommand.h"
#include "..\Factory\AddEdgeCommand.h"
#include "..\Factory\AddForestCommand.h"
#include "..\Factory\AddGrassCommand.h"
#include "..\Factory\AddRockCommand.h"
#include "..\Factory\AddStairsCommand.h"
#include "..\Factory\AddStoneWallCommand.h"
#include "..\Factory\AddTreeCommand.h"
#include "..\Factory\AddWaterCommand.h"
#include "..\Factory\DeclareCaveCommand.h"
#include "..\Factory\DeclareDungeonCommand.h"
#include "..\Factory\DeclareLandCommand.h"
#include "..\Factory\DeclareLotCommand.h"
#include "..\Factory\DeclareWorldCommand.h"
#include "..\Factory\AddBorderCommand.h"
#include "..\Factory\DeclareOverlayCommand.h"
#include "..\Factory\EndOverlayCommand.h"
#include "..\Model\StateMachine.h"

using namespace Windows::Foundation::Collections;
using namespace std;

class StateMachine
{
public:
	StateMachine();
	~StateMachine();

	World * Process(
		float2 fScreenDimensions,
		const shared_ptr<DeviceResources>& deviceResources);

protected:
	void Move(
		int nCommandType,
		World ** retVal,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pCurrentSubdivision,
		const shared_ptr<DeviceResources>& deviceResources);

	// TODO: Use function pointers.
	void DoState0(
		int nCommandType,
		World ** retVal,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pCurrentSubdivision,
		const shared_ptr<DeviceResources>& deviceResources);

	void DoState1(
		int nCommandType,
		World ** retVal,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pCurrentSubdivision,
		const shared_ptr<DeviceResources>& deviceResources);

	void DoState2(
		int nCommandType,
		World ** retVal,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pCurrentSubdivision,
		const shared_ptr<DeviceResources>& deviceResources);

private:
	int m_nStateId;
	BuildCommand * m_buildCommands[16];

};
