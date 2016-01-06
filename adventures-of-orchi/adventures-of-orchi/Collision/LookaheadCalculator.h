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
#pragma once
#include "..\Model\Movable.h"
#include "..\Grid.h"

// Calculate the next location.
class LookaheadCalculator
{
public:
	float Calculate(
		Movable * pMovable,
		int nHeading,
		float2 fWindowSize,
		float fVelocity,
		int nFramesPerSecond,
		Grid * grid,
		float * fLookaheadZone,
		float2 * fLookaheadPt);

protected:
	float CalculateGridsPerFrame(
		Movable * pMovable, 
		int nHeading,
		float fVelocity, 
		int nFramesPerSecond);

	void CalculateLookaheadZone(
		float2 fLocationRatio,
		int nHeading,
		XMFLOAT3 * vec3Differential,
		float2 fScreenDimensions,
		Grid * grid,
		float * fLookaheadZone,
		float2 * fLookaheadPt);

private:
};
