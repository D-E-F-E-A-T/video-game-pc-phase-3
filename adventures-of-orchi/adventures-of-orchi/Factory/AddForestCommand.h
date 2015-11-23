#pragma once
#include "BuildCommand.h"
#include "..\Model\World.h"

class AddForestCommand : public BuildCommand
{
public:
	void Process(
		World ** pWorld,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pSubdivision,
		const shared_ptr<DeviceResources>& deviceResources)
	{
	}

protected:

private:
};
