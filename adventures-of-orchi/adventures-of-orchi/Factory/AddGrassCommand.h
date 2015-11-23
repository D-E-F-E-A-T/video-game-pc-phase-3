#pragma once
#include "BuildCommand.h"
#include "..\Model\Grass.h"
#include "..\Utils.h"
#include "..\Model\World.h"

class AddGrassCommand : public BuildCommand
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
			((ServiceProxy::AddGrassCommand ^)command)->X,
			((ServiceProxy::AddGrassCommand ^)command)->Y,
			&x,
			&y);

		(*pSubdivision)->Set(LAYER_BACKGROUND,
			new Grass(
				float2(x, y),
				0.f,
				float2(1.f, 1.f),
				true,
				deviceResources));
	}

protected:

private:
};
