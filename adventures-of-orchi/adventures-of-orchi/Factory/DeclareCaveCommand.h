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
		int nColumn = ((ServiceProxy::DeclareCaveCommand ^)command)->Column;
		int nRow = ((ServiceProxy::DeclareCaveCommand ^)command)->Row;

		int red = ((ServiceProxy::DeclareCaveCommand ^)command)->Red;
		int green = ((ServiceProxy::DeclareCaveCommand ^)command)->Green;
		int blue = ((ServiceProxy::DeclareCaveCommand ^)command)->Blue;

		Region * region = (*pWorld)->GetRegion(regionId);
		*pSubdivision = region->GetSubdivision(nColumn, nRow);
		(*pSubdivision)->SetColor(red, green, blue);
	}

protected:

private:
};
