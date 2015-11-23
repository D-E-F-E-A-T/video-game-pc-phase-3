#pragma once
#include "BuildCommand.h"
#include "..\Model\Grass.h"
#include "..\Utils.h"
#include "..\Model\Region.h"
#include "..\Model\World.h"
#include "..\Model\Land.h"

class DeclareLandCommand : public BuildCommand
{
public:
	void Process(
		World ** pWorld,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pSubdivision,
		const shared_ptr<DeviceResources>& deviceResources)
	{
		String ^ strName = ((ServiceProxy::DeclareLandCommand ^)command)->Name;
		int x = ((ServiceProxy::DeclareLandCommand ^)command)->X;
		int y = ((ServiceProxy::DeclareLandCommand ^)command)->Y;

		(*pWorld)->AddRegion(new Land(strName, x, y));
	}

protected:

private:
};
