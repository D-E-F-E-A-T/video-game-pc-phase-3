#pragma once
#include "pch.h"
#include "Portal.h"
#include "Constants.h"
#include "Player.h"
#include "Space.h"
#include "Texture.h"
#include "..\World.h"
//#include "..\Content\GameRenderer.h"

class Stairs : public Portal
{
public:
	Stairs(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensionRatio,
		int nDestination,
		const shared_ptr<DeviceResources>& deviceResources) :
		Portal(
			pfLocationRatio,
			fRotationInRadians,
			pfDimensionRatio,
			nDestination,
			true,
			deviceResources)
	{
		m_pRenderable = new Texture("stairs.dds", deviceResources);
	}

	bool IsOverlapping(Player * pPlayer, Space * pSpace);

	//int Act(GameRenderer *, World *);

protected:

private:

};