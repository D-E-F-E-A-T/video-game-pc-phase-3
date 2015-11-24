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

	for (iterator = spaces->begin(); iterator != spaces->end(); iterator++)
	{
		if ((*iterator)->IsOverlapping(player))
		{			
			return (*iterator);
		}
	}

	return retVal;
}