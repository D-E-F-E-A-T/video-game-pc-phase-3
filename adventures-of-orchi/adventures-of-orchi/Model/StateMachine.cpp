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
}

World * Process(float2 fScreenDimensions, const shared_ptr<DeviceResources>& deviceResources)
{
	World * retVal = nullptr;

	ServiceProxy::ServiceProxy ^ proxy = ref new ServiceProxy::ServiceProxy();

	IIterable<ServiceProxy::BuildCommand ^> ^ commands = proxy->Build();

	String ^ strCurrentRegionId;

	Subdivision * pCurrentSubdivision = nullptr;

	for each (ServiceProxy::BuildCommand ^ command in commands)
	{
		// Add state machine.
		for (int i = 0; i < 16; i++)
		{
			if (command->Type == i)
			{
				Process(
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

void StateMachine::Process(
	int nCommandType,
	World ** retVal,
	float2 fScreenDimensions,
	ServiceProxy::BuildCommand ^ command,
	Subdivision * pCurrentSubdivision,
	const shared_ptr<DeviceResources>& deviceResources)
{
	// TODO: Use function pointers.

}

void StateMachine::DoState0()
{

}

void StateMachine::DoState1()
{

}

void StateMachine::DoState2()
{

}