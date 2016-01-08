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
	float2 fCenter_screen_ratio,
	int nHeading,
	Stack * stack,
	list<Space *> * retVal,
	float fBroadRadius_grid_ratio,
	Grid * pGrid)
{
	Calculate(
		nLayer,
		fCenter_screen_ratio,
		nHeading,
		stack, 
		retVal,
		fBroadRadius_grid_ratio,
		pGrid);
}

int BroadCollisionStrategy::Calculate(
	int nLayer, 
	float2 fCenter_screen_ratio,
	int nHeading,
	Stack * stack,
	list<Space *> * retVal,
	float fBroadRadius_grid_ratio,
	Grid * pGrid)
{
	int numLayers = stack->GetNumLayers();

	std::vector<Space *>::const_iterator iterator;

	for (iterator = stack->Get(nLayer)->GetSpaces()->begin();
		iterator != stack->Get(nLayer)->GetSpaces()->end();
		iterator++)
	{
		if (IsClose(fCenter_screen_ratio, nHeading, *(iterator), fBroadRadius_grid_ratio, pGrid))
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
	float2 fCenter_screen_ratio,
	int nHeading,
	Space * pObstacle,
	float fBroadRadius_grid_ratio,
	Grid * pGrid)
{
	// Need to convert ratios into pixels locations.
	//	Will convert relative to the grid, rather than globally.
	float fSourceX = 0.0f;
	float fSourceY = 0.0f;

	float fObstacleX = 0.0f;
	float fObstacleY = 0.0f;

	Utils::ConvertScreenRatioToGridRatio(
		fCenter_screen_ratio, &fSourceX, &fSourceY);

	Utils::ConvertScreenRatioToGridRatio(
		pObstacle->GetLocationRatio(), &fObstacleX, &fObstacleY);

	XMVECTOR vecSourceLocation_grid_px =
	{
		fSourceX * pGrid->GetGridWidth(),
		fSourceY * pGrid->GetGridHeight()
	};

	XMVECTOR vecObstacleLocation_grid_px =
	{
		fObstacleX * pGrid->GetGridWidth(),
		fObstacleY * pGrid->GetGridHeight()
	};

	float2 fSourceLocation_grid_px
	{
		XMVectorGetX(vecSourceLocation_grid_px),
		XMVectorGetY(vecSourceLocation_grid_px)
	};

	float2 fObstacleLocation_grid_px
	{ 
		XMVectorGetX(vecObstacleLocation_grid_px), 
		XMVectorGetY(vecObstacleLocation_grid_px) 
	};

	float2 fBroadZoneDimensions_grid_px
	{ 
		fBroadRadius_grid_ratio * pGrid->GetGridWidth(),
		fBroadRadius_grid_ratio * pGrid->GetGridHeight()
	};

	//return Utils::IsPointInEllipse(
	//	fObstacleLocation_grid_px,
	//	fSourceLocation_grid_px,
	//	fBroadZoneDimensions_grid_px);

	return Utils::IsPointInRectangle(
		fObstacleLocation_grid_px,
		fSourceLocation_grid_px,
		fBroadZoneDimensions_grid_px);

}