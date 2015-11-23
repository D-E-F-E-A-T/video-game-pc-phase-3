#pragma once
#include "pch.h"
#include "..\Model\Subdivision.h"

class BuildCommand
{
public:
	virtual void Process(
		World ** pWorld,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pSubdivision,
		const shared_ptr<DeviceResources>& deviceResources) = 0;

protected:

private:
};