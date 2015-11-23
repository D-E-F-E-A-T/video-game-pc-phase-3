#pragma once
#include "BuildCommand.h"
#include "..\Model\Edge.h"
#include "..\Utils.h"
#include "..\Model\World.h"

class AddEdgeCommand : public BuildCommand
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
			((ServiceProxy::AddEdgeCommand ^)command)->X,
			((ServiceProxy::AddEdgeCommand ^)command)->Y,
			&x,
			&y);

		(*pSubdivision)->Set(LAYER_2D,
			new Edge(
				float2(x, y),
				0.f,
				float2(0.2f, 0.2f),
				((ServiceProxy::AddEdgeCommand ^)command)->Direction,
				((ServiceProxy::AddEdgeCommand ^)command)->Destination,
				deviceResources));
	}

protected:

private:
};
