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
#include "..\Utils.h"
#include "..\Model\Region.h"
#include "..\Model\World.h"
#include "..\Model\Lot.h"

class DeclareLotCommand : public BuildCommand
{
public:
	void Process(
		World ** pWorld,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pSubdivision,
		const shared_ptr<DeviceResources>& deviceResources)
	{
		int id = ((ServiceProxy::DeclareLotCommand ^)command)->Id;
		int x = ((ServiceProxy::DeclareLotCommand ^)command)->X;
		int y = ((ServiceProxy::DeclareLotCommand ^)command)->Y;

		int red = ((ServiceProxy::DeclareLotCommand ^)command)->Red;
		int green = ((ServiceProxy::DeclareLotCommand ^)command)->Green;
		int blue = ((ServiceProxy::DeclareLotCommand ^)command)->Blue;

		Region * region = (*pWorld)->GetRegion(id);
		*pSubdivision = region->GetSubdivision(x, y);
		(*pSubdivision)->SetColor(red, green, blue);
	}

protected:

private:
};
