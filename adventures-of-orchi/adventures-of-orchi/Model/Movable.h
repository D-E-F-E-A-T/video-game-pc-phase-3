#pragma once
#include "Space.h"

using namespace Platform;

class Movable : public Space
{
public:
	Movable(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources)
		: Space(
			pfLocationRatio,
			fRotationInRadians,
			bIsVisible,
			false,
			true,
			deviceResources)
	{

	}

	void MoveNorth(int nCollisionState, float fVelocity);
	void MoveEast(int nCollisionState, float fVelocity);
	void MoveSouth(int nCollisionState, float fVelocity);
	void MoveWest(int nCollisionState, float fVelocity);

	virtual void Inertia(float fVelocity);
	void Stop();

protected:
	int m_nDirection;
	int m_fVelocity;

private:

};