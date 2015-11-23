#pragma once
#include "BuildCommand.h"
#include "..\Model\StoneWall.h"
#include "..\Utils.h"
#include "..\Model\World.h"

class AddStoneWallCommand : public BuildCommand
{
public:
	void Process(
		World ** pWorld,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pSubdivision,
		const shared_ptr<DeviceResources>& deviceResources)
	{
		float x;
		float y;

		Utils::CalculateSquareCenter(
			fScreenDimensions.x,
			fScreenDimensions.y,
			((ServiceProxy::AddStoneWallCommand ^)command)->X,
			((ServiceProxy::AddStoneWallCommand ^)command)->Y,
			&x,
			&y);

		(*pSubdivision)->Set(LAYER_COLLIDABLES,
			new StoneWall(
				float2(x, y),
				0.f,
				float2(1.f, 1.f),
				true,
				deviceResources));
	}

protected:

private:
};
