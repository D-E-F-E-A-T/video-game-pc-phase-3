#include "pch.h"
#include "Edge.h"
#include "Player.h"

bool Edge::IsOverlapping(Space * pOther)
{
	float fDistance = this->CalculateDistance(pOther);

	return (fDistance < 0.05f);
}
