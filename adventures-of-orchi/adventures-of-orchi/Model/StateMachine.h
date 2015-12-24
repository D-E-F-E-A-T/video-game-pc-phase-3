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

class StateMachine
{
public:
	StateMachine();

	World * Process(
		BuildCommand ** buildCommands,
		float2 fScreenDimensions,
		const shared_ptr<DeviceResources>& deviceResources);

protected:
	void Process(
		int nCommandType,
		World ** retVal,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision * pCurrentSubdivision,
		const shared_ptr<DeviceResources>& deviceResources);

	// TODO: Use function pointers.
	void DoState0();
	void DoState1();
	void DoState2();

private:
	int m_nStateId;

};
