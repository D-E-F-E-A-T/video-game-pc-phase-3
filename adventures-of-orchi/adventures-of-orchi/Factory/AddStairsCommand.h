#pragma once
#include "BuildCommand.h"
#include "..\Model\Stairs.h"
#include "..\Utils.h"
#include "..\Model\World.h"

class AddStairsCommand : public BuildCommand
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
			((ServiceProxy::AddStairsCommand ^)command)->X,
			((ServiceProxy::AddStairsCommand ^)command)->Y,
			&x,
			&y);

		(*pSubdivision)->Set(LAYER_PORTALS,
			new Stairs(
				float2(x, y),
				0.f,
				float2(0.75f, 0.75f),
				((ServiceProxy::AddStairsCommand ^)command)->Destination,
				deviceResources));
	}

protected:

private:
};
