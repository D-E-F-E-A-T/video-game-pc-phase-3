#pragma once
#include "BuildCommand.h"
#include "..\Model\Grass.h"
#include "..\Utils.h"
#include "..\Model\Region.h"
#include "..\Model\World.h"

class DeclareCaveCommand : public BuildCommand
{
public:
	void Process(
		World ** pWorld,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pSubdivision,
		const shared_ptr<DeviceResources>& deviceResources)
	{
		int regionId = ((ServiceProxy::DeclareCaveCommand ^)command)->RegionId;
		int x = ((ServiceProxy::DeclareCaveCommand ^)command)->X;
		int y = ((ServiceProxy::DeclareCaveCommand ^)command)->Y;

		Region * region = (*pWorld)->GetRegion(regionId);
		*pSubdivision = region->GetSubdivision(x, y);
	}

protected:

private:
};
