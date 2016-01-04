/*
Copyright 2016 Richard Bernardino

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
#include "pch.h"
#include "BroadCollisionStrategy.h"
#include <vector>
#include "Model\Movable.h"
#include "Utils.h"
#include <iostream>
#include "Utils.h"
#include "Model\Stack.h"

// @see http://www.gamedev.net/page/resources/_/technical/directx-and-xna/pixel-perfect-collision-detection-in-directx-r2939
BroadCollisionStrategy::BroadCollisionStrategy()
{

}

void BroadCollisionStrategy::Detect(
	int nLayer,
	Movable * pMovable,
	Stack * stack,
	list<Space *> * retVal,
	XMFLOAT3 * vecDifferential,
	Grid * pGrid)
{
	Calculate(
		nLayer,
		pMovable,
		stack, 
		retVal,
		vecDifferential,
		pGrid);
}

int BroadCollisionStrategy::Calculate(
	int nLayer, 
	Movable * pMovable,
	Stack * stack,
	list<Space *> * retVal,
	XMFLOAT3 * vecDifferential,
	Grid * pGrid)
{
	int numLayers = stack->GetNumLayers();

	std::vector<Space *>::const_iterator iterator;

	for (iterator = stack->Get(nLayer)->GetSpaces()->begin();
		iterator != stack->Get(nLayer)->GetSpaces()->end();
		iterator++)
	{
		if (IsClose(pMovable, *(iterator), vecDifferential, pGrid))
		{
			retVal->push_back(*(iterator));
		}
	}

	return 1;
}

bool BroadCollisionStrategy::IsClose(
	Movable * pMovable,
	Space * obstacle,
	XMFLOAT3 * vec3DifferentialGrid,	// Relative to the grid, NOT globally.
	Grid * pGrid)
{
	float distance = obstacle->CalculateDistance(pMovable, vec3DifferentialGrid);

	// Does the obstacle fall within the circle centered
	//	at the lookahead point?
	XMVECTOR vecLookahead = XMLoadFloat3(vec3DifferentialGrid);
	float fLookaheadDistance = XMVectorGetX(XMVector3Length(vecLookahead));

	return (distance <= fLookaheadDistance);

	// Calculate distance from obstacle to lookahead point.
/*
	XMVECTOR vecDifferentialGrid = XMLoadFloat3(vec3DifferentialGrid);

	XMVECTOR vecDifferentialGlobal =
		XMVectorSet(
			(XMVectorGetX(vecDifferentialGrid) * pGrid->GetGridWidth()) / pGrid->GetWindowWidth(),
			(XMVectorGetY(vecDifferentialGrid) * pGrid->GetGridHeight()) / pGrid->GetWindowHeight(),
			0.0f,
			0.0f);

	XMVECTOR vecLocation =
		XMVectorSet(
			pMovable->GetLocationRatio().x,
			pMovable->GetLocationRatio().y,
			0.0f,
			0.0f);

	XMVECTOR vecResultant = vecLocation + vecDifferentialGlobal;

	XMFLOAT3 vec3Resultant
	{
		XMVectorGetX(vecResultant),
		XMVectorGetY(vecResultant),
		0.0f
	};

	float distance = obstacle->CalculateDistance(pMovable, &vec3Resultant);
	
	// Does the obstacle fall within the circle centered
	//	at the lookahead point?
	XMVECTOR vecLookahead = XMLoadFloat3(vec3DifferentialGrid);
	float fLookaheadDistance = XMVectorGetX(XMVector3Length(vecLookahead));

	return (distance <= fLookaheadDistance);
*/
}