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
		int nId = ((ServiceProxy::DeclareLandCommand ^)command)->Id;

		int nX = ((ServiceProxy::DeclareLandCommand ^)command)->X;
		int nY = ((ServiceProxy::DeclareLandCommand ^)command)->Y;

		int nEntryX = ((ServiceProxy::DeclareLandCommand ^)command)->EntryX;
		int nEntryY = ((ServiceProxy::DeclareLandCommand ^)command)->EntryY;

		int nRed = ((ServiceProxy::DeclareLandCommand ^)command)->Red;
		int nGreen = ((ServiceProxy::DeclareLandCommand ^)command)->Green;
		int nBlue = ((ServiceProxy::DeclareLandCommand ^)command)->Blue;

		(*pWorld)->AddRegion(new Land(nId, nX, nY, nEntryX, nEntryY, nRed, nGreen, nBlue));
	}

protected:

private:
};
