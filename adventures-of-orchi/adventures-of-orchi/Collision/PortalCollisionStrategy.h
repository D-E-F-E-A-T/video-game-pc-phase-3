#pragma once
#include "pch.h"
#include "..\Model\Space.h"
#include "..\Model\Player.h"
#include "..\Model\Stack.h"
#include "..\Model\Portal.h"

class PortalCollisionStrategy
{
public:
	Space * Detect(Player * pPlayer, list<Space *> * spaces);

protected:
	bool IsOverlapping(Player * player, Space * obstacle, float * fDistance);

private:
};
