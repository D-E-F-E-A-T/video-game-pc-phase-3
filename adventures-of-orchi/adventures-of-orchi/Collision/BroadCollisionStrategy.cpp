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
	int nHeading,
	Stack * stack,
	list<Space *> * retVal,
	float fLookaheadDistance_grid_ratio,
	float fLookaheadRadius_grid_ratio,
	Grid * pGrid)
{
	Calculate(
		nLayer,
		pMovable,
		nHeading,
		stack, 
		retVal,
		fLookaheadDistance_grid_ratio,
		fLookaheadRadius_grid_ratio,
		pGrid);
}

int BroadCollisionStrategy::Calculate(
	int nLayer, 
	Movable * pMovable,
	int nHeading,
	Stack * stack,
	list<Space *> * retVal,
	float fLookaheadDistance_grid_ratio,
	float fLookaheadRadius_grid_ratio,
	Grid * pGrid)
{
	int numLayers = stack->GetNumLayers();

	std::vector<Space *>::const_iterator iterator;

	for (iterator = stack->Get(nLayer)->GetSpaces()->begin();
		iterator != stack->Get(nLayer)->GetSpaces()->end();
		iterator++)
	{
		if (IsClose(pMovable, nHeading, *(iterator), fLookaheadDistance_grid_ratio, fLookaheadRadius_grid_ratio, pGrid))
		{
			retVal->push_back(*(iterator));
		}
	}

	return 1;
}

/**
 * vec3Differential Vector representing the lookahead point.
 *	The components of this vector represent percentages
 *	of the grid.
 *	For example, <0.2f, 0.2f, 0.0f> for a 1920 x 1080 screen
 *	is <230.4f, 216.0f, 0.0f> in pixels. 
 *	(With .2 left and right margins. 0 top and bottom margins.
 */
bool BroadCollisionStrategy::IsClose(
	Movable * pMovable,
	int nHeading,
	Space * pObstacle,
	float fLookaheadDistance_grid_ratio,
	float fLookaheadRadius_grid_ratio,
	Grid * pGrid)
{
	// Need to convert ratios into pixels locations.
	//	Will convert relative to the grid, rather than globally.
	float fMovableX = 0.0f;
	float fMovableY = 0.0f;

	float fObstacleX = 0.0f;
	float fObstacleY = 0.0f;

	Utils::ConvertScreenRatioToGridRatio(
		pMovable->GetLocationRatio(), &fMovableX, &fMovableY);

	Utils::ConvertScreenRatioToGridRatio(
		pObstacle->GetLocationRatio(), &fObstacleX, &fObstacleY);

	XMVECTOR vecMovableLocation_grid_px =
	{
		fMovableX * pGrid->GetGridWidth(),
		fMovableY * pGrid->GetGridHeight()
	};

	XMVECTOR vecObstacleLocation_grid_px =
	{
		fObstacleX * pGrid->GetGridWidth(),
		fObstacleY * pGrid->GetGridHeight()
	};


	XMFLOAT3 vec3Lookahead_grid_px;

	switch (nHeading)
	{
	case NORTH:
		vec3Lookahead_grid_px = { 0.0f, -1.0f * fLookaheadDistance_grid_ratio * pGrid->GetGridHeight(), 0.0f };
		break;

	case EAST:
		vec3Lookahead_grid_px = { fLookaheadDistance_grid_ratio * pGrid->GetGridWidth(), 0.0f, 0.0f };
		break;

	case SOUTH:
		vec3Lookahead_grid_px = { 0.0f, fLookaheadDistance_grid_ratio * pGrid->GetGridHeight(), 0.0f };
		break;

	case WEST:
		vec3Lookahead_grid_px = { -1.0f * fLookaheadDistance_grid_ratio * pGrid->GetGridWidth(), 0.0f, 0.0f };
		break;
	}

	XMVECTOR vecLookahead_grid_px = XMLoadFloat3(&vec3Lookahead_grid_px);

	XMVECTOR vecResultant_grid_px = vecMovableLocation_grid_px + vecLookahead_grid_px;

	float2 fObstacleLocation_grid_px
	{ 
		XMVectorGetX(vecObstacleLocation_grid_px), 
		XMVectorGetY(vecObstacleLocation_grid_px) 
	};

	float2 fResultantLocation_grid_px
	{ 
		XMVectorGetX(vecResultant_grid_px), 
		XMVectorGetY(vecResultant_grid_px) 
	};

	float2 fLookaheadZoneDimensions_grid_px
	{ 
		fLookaheadDistance_grid_ratio * pGrid->GetGridWidth() / 2.0f, 
		fLookaheadDistance_grid_ratio * pGrid->GetGridHeight() / 2.0f 
	};

	return Utils::IsPointInEllipse(
		fObstacleLocation_grid_px,
		fResultantLocation_grid_px,
		fLookaheadZoneDimensions_grid_px);





//		float2 fEllipseDimensions);


	// Calculate distance from obstacle to lookahead point.
/*
	XMVECTOR vecLookaheadGrid = XMLoadFloat3(vec3LookaheadGrid);

	XMVECTOR vecLookaheadGlobal =
		XMVectorSet(
			(XMVectorGetX(vecLookaheadGrid) * pGrid->GetGridWidth()) / pGrid->GetWindowWidth(),
			(XMVectorGetY(vecLookaheadGrid) * pGrid->GetGridHeight()) / pGrid->GetWindowHeight(),
			0.0f,
			0.0f);

	XMFLOAT3 vec3LookaheadGlobal
	{
		XMVectorGetX(vecLookaheadGlobal),
		XMVectorGetY(vecLookaheadGlobal),
		0.0f
	};
*/
/*
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
*/

	//float2 fDistanceGlobal = obstacle->CalculateDistance(pMovable, &vec3LookaheadGlobal);



	//float fDistanceGrid = 0.0f;

	// TODO: Using parabolic functions will remove need for case statements.
	//	Will be needed when steering becomes 360 degrees.
/*
	if (nHeading % 2 == 0)
	{
		// NORTH or SOUTH.
		fDistanceGrid = (fDistanceGlobal * pGrid->GetWindowHeight()) / pGrid->GetGridHeight();
	}
	else
	{
		// EAST or WEST.
		fDistanceGrid = (fDistanceGlobal * pGrid->GetWindowWidth()) / pGrid->GetGridWidth();
	}
*/

//	float fDistanceGridX = (fDistanceGlobal * pGrid->GetWindowWidth()) / pGrid->GetGridWidth();
//	float fDistanceGridY = (fDistanceGlobal * pGrid->GetWindowHeight()) / pGrid->GetGridHeight();
//
//	fDistanceGrid =
//		sqrt(fDistanceGridX * fDistanceGridX + fDistanceGridY * fDistanceGridY);
//
//#ifdef _DEBUG
//	char buf[64];
//	sprintf_s(buf, "fDistanceGlobal = %f fDistanceGrid = %f\n", fDistanceGlobal, fDistanceGrid);
//	OutputDebugStringA(buf);
//#endif // _DEBUG
//	
//	// Must compare globals to globals and grids to grids.
////	XMVECTOR vecLookaheadGrid = XMLoadFloat3(vec3LookaheadGrid);
////	float fLookaheadDistanceGrid = XMVectorGetX(XMVector3Length(vecLookaheadGrid));
//
//	return (fDistanceGrid <= fLookaheadGridRadius);

}