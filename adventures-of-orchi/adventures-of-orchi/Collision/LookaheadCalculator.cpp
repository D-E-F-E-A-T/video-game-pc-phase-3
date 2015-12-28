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
#include "LookaheadCalculator.h"

float LookaheadCalculator::CalculateGridsPerFrame(
	Movable * pMovable, 
	int nHeading,
	float fVelocity, 
	int nFramesPerSecond)
{
	// Calculate the frames/grid at the current FPS.
	//	Ex: 60 FPS * 5 (frames per grid) = 300 frames per grid.
	float fFramesPerGrid = (float)nFramesPerSecond * fVelocity;

	// Length of each ratio division.
	// Ex: 1.0f / 300 (frames per grid) = 0.00333 grid / frame. gy
	//	Or ("Move 0.003333 grid for every frame")
	float fGridsPerFrame = 1.0f / fFramesPerGrid;

/*
	XMFLOAT3 retVal;

	switch (nHeading)
	{
	case NORTH:
		retVal = { 0.0f, -1.0f * fGridsPerFrame, 0.0f };
		break;

	case EAST:
		retVal = { fGridsPerFrame, 0.0f, 0.0f };
		break;

	case SOUTH:
		retVal = { 0.0f, fGridsPerFrame, 0.0f };
		break;

	case WEST:
		retVal = { -1.0f * fGridsPerFrame, 0.0f, 0.0f };
		break;
	}
*/

	return retVal;
}