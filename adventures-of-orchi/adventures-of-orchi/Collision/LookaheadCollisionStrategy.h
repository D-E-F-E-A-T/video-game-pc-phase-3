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
#include "pch.h"
#include "TextureCollisionStrategy.h"

using namespace std;

class LookaheadCollisionStrategy
{
public:
	bool Detect(
		Movable * pMovable,	// in, out
		Space * collided,	// in
		Grid * grid,		// in
		int * intersectRect,
		float2 screenDimensions,
		int nHeading,
		float2 fLookaheadPt,
		vector<D2D1_RECT_F> * pCollidedRects,
		vector<int> * pCollidedRectStatuses);

protected:


private:
	TextureCollisionStrategy m_narrowCollisionDetectionStrategy;
};
