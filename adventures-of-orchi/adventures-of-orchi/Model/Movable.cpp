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
#include "Movable.h"

using namespace DirectX;

void Movable::MoveNorth(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION /* && m_nDirection == NORTH */)
	{
	}
	else
	{
		float prospectiveVerticalRatio =
			m_fLocationRatio.y -= fVelocity;

		// Don't go above the top of the screen. 
		//	Later this will be the trigger to move to the next screen.
		if (prospectiveVerticalRatio >= 0.f)
			m_fLocationRatio.y = prospectiveVerticalRatio;
		else
			m_fLocationRatio.y = 0.0f;

		m_fRotationInRadians = XMConvertToRadians(0.f);
	}

	m_nDirection = NORTH;
	m_fVelocity = fVelocity;
}

void Movable::MoveEast(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION /* && m_nDirection == EAST */)
	{
	}
	else
	{
		float prospectiveHorizontalRatio =
			m_fLocationRatio.x += fVelocity;

		if (prospectiveHorizontalRatio <= 1.0f)
		{
			m_fLocationRatio.x = prospectiveHorizontalRatio;
		}
		else
		{
			m_fLocationRatio.x = 1.0f;
		}

		m_fRotationInRadians = XMConvertToRadians(-90.f);
	}

	m_nDirection = EAST;
	m_fVelocity = fVelocity;
}

void Movable::MoveSouth(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION /* && m_nDirection == SOUTH */)
	{
	}
	else
	{
		float prospectiveVerticalOffset =
			m_fLocationRatio.y += fVelocity;

		// Don't go above the top of the screen. 
		//	Later this will be the trigger to move to the next screen.
		if (prospectiveVerticalOffset <= 1.0f)
			m_fLocationRatio.y = prospectiveVerticalOffset;
		else
			m_fLocationRatio.y = 1.0f;

		m_fRotationInRadians = XMConvertToRadians(180.f);
	}

	m_nDirection = SOUTH;
	m_fVelocity = fVelocity;
}

void Movable::MoveWest(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION /* && m_nDirection == WEST */)
	{
	}
	else
	{
		float prospectiveHorizontalOffset =
			m_fLocationRatio.x -= fVelocity;

		if (prospectiveHorizontalOffset >= 0.f)
		{
			m_fLocationRatio.x = prospectiveHorizontalOffset;
		}
		else
		{
			m_fLocationRatio.x = 0.f;
		}

		m_fRotationInRadians = XMConvertToRadians(90.f);
	}

	m_nDirection = WEST;
	m_fVelocity = fVelocity;
}

void Movable::Inertia(float fVelocity)
{
	Move(m_nDirection, NO_INTERSECTION, fVelocity);
}

void Movable::Stop()
{

}