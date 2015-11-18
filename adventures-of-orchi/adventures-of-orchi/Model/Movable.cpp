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