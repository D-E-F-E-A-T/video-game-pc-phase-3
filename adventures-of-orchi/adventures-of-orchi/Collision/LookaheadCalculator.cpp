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
#include "..\Constants.h"
#include "LookaheadCalculator.h"
#include "..\Grid.h"

// @return Ratio relative to the grid, only.
float LookaheadCalculator::Calculate(
	Movable * pMovable,
	int nHeading,
	float2 fWindowSize,
	float fVelocity,	// Travel 1/5 of a grid/sec.
	int nFramesPerSecond,
	Grid * grid, // Player location is the coordinates of the center of the sprite.
	float * pLookaheadZone,
	float2 * fLookaheadPt)
{
	float fGridsPerFrame = grid->CalculateGridsPerFrame(
		fVelocity,
		nFramesPerSecond);

	CalculateLookaheadZone(
		pMovable->GetLocationRatio(),
		nHeading,
		fGridsPerFrame,
		fWindowSize,
		grid,
		pLookaheadZone,
		fLookaheadPt);

	return fGridsPerFrame;
}

void LookaheadCalculator::CalculateLookaheadZone(
	float2 fLocationRatio,
	int nHeading,
	float fGridsPerFrame,	// Relative to the grid, NOT to global.
	float2 fScreenDimensions,
	Grid * grid, // Player location is the coordinates of the center of the sprite.
	float * fLookaheadZone,
	float2 * fLookaheadPtRatio)
{
	XMFLOAT3 vec3Lookahead;

	switch (nHeading)
	{
	case NORTH:
		vec3Lookahead = { 0.0f, -1.0f * fGridsPerFrame, 0.0f };
		break;

	case EAST:
		vec3Lookahead = { fGridsPerFrame, 0.0f, 0.0f };
		break;

	case SOUTH:
		vec3Lookahead = { 0.0f, fGridsPerFrame, 0.0f };
		break;

	case WEST:
		vec3Lookahead = { -1.0f * fGridsPerFrame, 0.0f, 0.0f };
		break;
	}

	XMVECTOR vecLookahead = XMLoadFloat3(&vec3Lookahead);
	int playerTopLeftTranslated[2];
	int playerTopLeft[2];

	float2 fGridPixels =
	{
		fScreenDimensions.x * (1.0f - LEFT_MARGIN_RATIO - RIGHT_MARGIN_RATIO),
		fScreenDimensions.y * (1.0f - TOP_MARGIN_RATIO - BOTTOM_MARGIN_RATIO)
	};

	// Should really use the dimensions of the sprite.
	//	For now, using the dimensions of the grid space.
	*fLookaheadPtRatio =
	{
		fLocationRatio.x + ((XMVectorGetX(vecLookahead) * fGridPixels.x) / fScreenDimensions.x),
		fLocationRatio.y + ((XMVectorGetY(vecLookahead) * fGridPixels.y) / fScreenDimensions.y)
	};

	float2 fPlayerTopLeftTranslated =
	{
		(fLookaheadPtRatio->x * fScreenDimensions.x) - grid->GetColumnWidth() / 2.f,
		(fLookaheadPtRatio->y * fScreenDimensions.y) - grid->GetRowHeight() / 2.f
	};

	float2 fPlayerTopLeft =
	{
		(fLocationRatio.x * fScreenDimensions.x) - grid->GetColumnWidth() / 2.f,
		(fLocationRatio.y * fScreenDimensions.y) - grid->GetRowHeight() / 2.f
	};

	switch (nHeading)
	{ 
		case NORTH:
		{
			fLookaheadZone[BOUNDS_LEFT] = fPlayerTopLeftTranslated.x;
			fLookaheadZone[BOUNDS_TOP] = fPlayerTopLeftTranslated.y;
			fLookaheadZone[BOUNDS_RIGHT] = fPlayerTopLeftTranslated.x + grid->GetColumnWidth();
			fLookaheadZone[BOUNDS_BOTTOM] = fPlayerTopLeft.y + grid->GetRowHeight();
		}
		break;

		case EAST:
		{
			fLookaheadZone[BOUNDS_LEFT] = fPlayerTopLeft.x;
			fLookaheadZone[BOUNDS_TOP] = fPlayerTopLeft.y;
			fLookaheadZone[BOUNDS_RIGHT] = fPlayerTopLeftTranslated.x + grid->GetColumnWidth();
			fLookaheadZone[BOUNDS_BOTTOM] = fPlayerTopLeft.y + grid->GetRowHeight();
		}
		break;

		case SOUTH:
		{
			fLookaheadZone[BOUNDS_LEFT] = fPlayerTopLeft.x;
			fLookaheadZone[BOUNDS_TOP] = fPlayerTopLeft.y;
			fLookaheadZone[BOUNDS_RIGHT] = fPlayerTopLeft.x + grid->GetColumnWidth();
			fLookaheadZone[BOUNDS_BOTTOM] = fPlayerTopLeftTranslated.y + grid->GetRowHeight();
		}
		break;

		case WEST:
		{
			fLookaheadZone[BOUNDS_LEFT] = fPlayerTopLeftTranslated.x;
			fLookaheadZone[BOUNDS_TOP] = fPlayerTopLeftTranslated.y;
			fLookaheadZone[BOUNDS_RIGHT] = fPlayerTopLeft.x + grid->GetColumnWidth();
			fLookaheadZone[BOUNDS_BOTTOM] = fPlayerTopLeftTranslated.y + grid->GetRowHeight();
		}
		break;
	}
}