#pragma once
#include "pch.h"
#include "Portal.h"
#include "Constants.h"
#include "Player.h"
#include "Space.h"
#include "Texture.h"

class Stairs : public Portal
{
public:
	Stairs(
		float2 pfLocationRatio,
		float2 pfDimensionRatio,
		int nDestination,
		const shared_ptr<DeviceResources>& deviceResources) :
		Portal(
			pfLocationRatio,
			pfDimensionRatio,
			nDestination,
			deviceResources)
	{
		m_pRenderable = new Texture("stairs.dds", deviceResources);
	}

	bool IsOverlapping(Player * pPlayer, Space * pSpace);

	void Act();

protected:

private:

};