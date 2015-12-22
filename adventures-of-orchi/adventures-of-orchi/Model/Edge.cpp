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
#include "Edge.h"
#include "Player.h"
#include "..\Utils.h"

// This is a two-pass algorithm. 
//	First, check if all the edge points
//	are within the Other.  
//	Then check if any point of the Other is
//	within the Edge.
bool Edge::IsOverlapping(Space * pOther)
{
	vector<D2D1_POINT_2F> edgeBounds;
	vector<D2D1_POINT_2F> otherBounds;

	edgeBounds.push_back(
		D2D1_POINT_2F 
		{
			m_fLocationRatio.x,
			m_fLocationRatio.y
		}
	);

	edgeBounds.push_back(
		D2D1_POINT_2F
		{
			m_fLocationRatio.x + m_fDimensionsRatio.x,
			m_fLocationRatio.y
		}
	);

	edgeBounds.push_back(
		D2D1_POINT_2F
		{
			m_fLocationRatio.x + m_fDimensionsRatio.x,
			m_fLocationRatio.y + m_fDimensionsRatio.y
		}
	);

	edgeBounds.push_back(
		D2D1_POINT_2F
		{
			m_fLocationRatio.x,
			m_fLocationRatio.y + m_fDimensionsRatio.y
		}
	);

	otherBounds.push_back(
		D2D1_POINT_2F
		{
			pOther->GetLocationRatio().x,
			pOther->GetLocationRatio().y
		}
	);

	otherBounds.push_back(
		D2D1_POINT_2F
		{
			pOther->GetLocationRatio().x + pOther->GetDimensionsRatio().x,
			pOther->GetLocationRatio().y
		}
	);

	otherBounds.push_back(
		D2D1_POINT_2F
		{
			pOther->GetLocationRatio().x + pOther->GetDimensionsRatio().x,
			pOther->GetLocationRatio().y + pOther->GetDimensionsRatio().y
		}
	);

	otherBounds.push_back(
		D2D1_POINT_2F
		{
			pOther->GetLocationRatio().x,
			pOther->GetLocationRatio().y + pOther->GetDimensionsRatio().y
		}
	);

	vector<D2D1_POINT_2F>::const_iterator iterator;

	for (iterator = edgeBounds.begin();
		iterator != edgeBounds.end();
		iterator++)
	{
		if (Utils::IsPointInPolygon(*(iterator), &otherBounds))
		{
			return true;
		}
	}

	for (iterator = otherBounds.begin();
		iterator != otherBounds.end();
		iterator++)
	{
		if (Utils::IsPointInPolygon(*(iterator), &edgeBounds))
		{
			return true;
		}
	}

	return false;
}
