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

		Region * region = (*pWorld)->GetRegion(id);
		*pSubdivision = region->GetSubdivision(x, y);
	}

protected:

private:
};
