#include "pch.h"
#include "Stairs.h"


bool Stairs::IsOverlapping(Space * pOther)
{
	float fDistance = this->CalculateDistance(pOther);

	return (fDistance < 0.01f);
}

//int Stairs::Act(GameRenderer * pRenderer, World * pWorld)
//{
////	pRenderer->SetCurrentStack(pWorld->Move((*iterator), DOWNSTAIRS));
//	return 1;
//}