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
#include "Constants.h"
#include "LookaheadCollisionStrategy.h"
#include "..\Model\Movable.h"
#include "..\Grid.h"
#include "..\Utils.h"

void LookaheadCollisionStrategy::Detect(
	Movable * pPlayer,
	Space * pCollided,
	Grid * pGrid,
	int * pnIntersectRect,
	float2 fScreenDimensions,
	XMFLOAT3 * pvec3Differential,
	int nHeading,
	float2 fLookaheadPt,
	vector<D2D1_RECT_F> * pCollidedRects,
	vector<int> * pCollidedRectStatuses)
{
	int nPixelDistance = Utils::CalculatePixelDistance(
		pPlayer->GetLocationRatio(),
		fLookaheadPt,
		fScreenDimensions);

	// Maybe need to use double for more precision?
	float2 fUnitRatio = Utils::UnitPixelToRatio(fScreenDimensions);

	// Do a sweep of the narrow CS starting from the current location
	//	up to the lookahead point.
	//	If a COLLISION is detected, move the player to that location
	//	- 1 px.  
	//	If a no collision is ever detected, move the player 
	//	to the lookahead point.
	XMFLOAT3 pvec3Displacement;
	XMFLOAT3 pvec3PreviousDisplacement;

	pvec3PreviousDisplacement = pvec3Displacement;

	for (int i = 0; i <= nPixelDistance; i++)
	{
		switch (nHeading)
		{
			case NORTH:
			{
				pvec3Displacement =
				{
					0.0f,
					fUnitRatio.y * (float)i * -1.0f,
					0.0f
				};
			}
			break;

			case EAST:
			{
				pvec3Displacement =
				{
					fUnitRatio.x * (float)i,
					0.0f,
					0.0f
				};
			}
			break;

			case SOUTH:
			{
				pvec3Displacement =
				{
					0.0f,
					fUnitRatio.y * (float)i,
					0.0f
				};
			}
			break;

			case WEST:
			{
				pvec3Displacement =
				{
					fUnitRatio.x * (float)i * -1.0f,
					0.0f,
					0.0f
				};
			}
			break;
		}

		int nCollisionState = m_narrowCollisionDetectionStrategy.Detect(
			pPlayer,
			pCollided,
			pGrid,
			pnIntersectRect,
			fScreenDimensions,
			&pvec3Displacement);

#ifdef _DEBUG
		if (nCollisionState != NO_INTERSECTION)
		{
			//if (m_nCollisionState == COLLISION)
			//{
			//	int actionCode = (*iterator)->Act(this, m_pWorld);

			//	if (actionCode == 1)
			//		return 0;
			//}

			D2D1_RECT_F rect
			{
				(float)pnIntersectRect[0],
				(float)pnIntersectRect[2],
				(float)pnIntersectRect[1],
				(float)pnIntersectRect[3]
			};

			pCollidedRects->push_back(rect);
			pCollidedRectStatuses->push_back(nCollisionState);
		}
#endif // _DEBUG

		if (nCollisionState == COLLISION)
		{
//			XMVECTOR vecDisplacement = XMLoadFloat3(&pvec3PreviousDisplacement);

			float2 fCurrentLocationRatio = pPlayer->GetLocationRatio();

			// Move the player AWAY from the obstacle.
			switch (nHeading)
			{
			case NORTH:
				pPlayer->SetLocationRatio(
					float2
					{
						fCurrentLocationRatio.x,
						fCurrentLocationRatio.y + fUnitRatio.y
					});
				break;

			case EAST:
				pPlayer->SetLocationRatio(
					float2
				{
					fCurrentLocationRatio.x - fUnitRatio.x,
					fCurrentLocationRatio.y
				});
				break;

			case SOUTH:
				pPlayer->SetLocationRatio(
					float2
				{
					fCurrentLocationRatio.x,
					fCurrentLocationRatio.y - fUnitRatio.y
				});
				break;

			case WEST:
				pPlayer->SetLocationRatio(
					float2
				{
					fCurrentLocationRatio.x + fUnitRatio.x,
					fCurrentLocationRatio.y
				});
				break;
			}

			return;
		}

		pvec3PreviousDisplacement = pvec3Displacement;
	}
}