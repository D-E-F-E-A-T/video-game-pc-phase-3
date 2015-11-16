#include "pch.h"
#include "PortalCollisionStrategy.h"
#include "..\Model\Space.h"
#include "..\Model\Stack.h"
#include "Utils.h"
#include "..\Model\Edge.h"


Space * PortalCollisionStrategy::Detect(
	Player * player,
	list<Space *> * spaces)
{
	Space * retVal = nullptr;

	std::list<Space *>::const_iterator iterator;
	vector<Space *> collidedEdges;
	vector<float> collidedEdgesDistances;

	float minValue = 999999.9f;

	for (iterator = spaces->begin(); iterator != spaces->end(); iterator++)
	{
		float fDistance;

		// Play can be overlapping multiple spaces.
		//	Find the overlapping, then find the closest
		//	to the center.
		if (IsOverlapping(player, *(iterator), &fDistance))
		{
			if (fDistance < minValue)
			{
				retVal = *iterator;
			}
		}
	}

	return retVal;
}

//bool PortalCollisionStrategy::IsOverlapping(
//	Player * player, 
//	Space * portal)
//{
//	//float2 playerLocation = player->GetLocationRatio();
//	//float2 playerSize = player->GetDimensionsRatio();
//
//	//float2 portalLocation = portal->GetLocationRatio();
//	//float2 portalSize = portal->GetDimensionsRatio();
//
//	return false;
//}


bool PortalCollisionStrategy::IsOverlapping(
	Player * player,
	Space * obstacle,
	float * pfDistance)
{
	*pfDistance = obstacle->CalculateDistance(player);

	return (*pfDistance < 0.075f);
}
