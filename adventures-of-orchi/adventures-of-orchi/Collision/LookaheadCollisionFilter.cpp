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
#include "LookaheadCollisionFilter.h"
#include "..\Utils.h"

void LookaheadCollisionFilter::Filter(
	list<Space *> * pFiltered,
	list<Space *> * pCollided,
	float2 fScreenDimensions,
	float * fCollisionZonePixels)
{
	D2D1_RECT_F rectCollisionZone
	{
		fCollisionZonePixels[BOUNDS_LEFT] / fScreenDimensions.x,
		fCollisionZonePixels[BOUNDS_TOP] / fScreenDimensions.y,
		fCollisionZonePixels[BOUNDS_RIGHT] / fScreenDimensions.x,
		fCollisionZonePixels[BOUNDS_BOTTOM] / fScreenDimensions.y
	}; 

	std::list<Space *>::const_iterator iterator;

	for (iterator = pCollided->begin(); iterator != pCollided->end(); iterator++)
	{
		if (Utils::AreOverlapping(&rectCollisionZone, *iterator))
		{
			pFiltered->push_back(*(iterator));
		}
	};
}