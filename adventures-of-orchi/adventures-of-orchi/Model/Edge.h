#pragma once
#include "pch.h"
#include "VectorGraphic.h"
#include "Portal.h"
#include "Constants.h"


class Edge : public Portal
{
public:
	Edge(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensionRatio,
		int nDirection,
		int nDestination,
		const shared_ptr<DeviceResources>& deviceResources) :
		Portal(
			pfLocationRatio,
			fRotationInRadians,
			pfDimensionRatio,
			nDestination,
			deviceResources)
	{
		m_nDirection = nDirection;
		m_pRenderable = new VectorGraphic(deviceResources);
	}

	int GetDirection() { return m_nDirection; }

	//Action * Act(World *);

	bool IsOverlapping(Player * pPlayer, Space * pSpace);

protected:

private:
	int m_nDirection;
};