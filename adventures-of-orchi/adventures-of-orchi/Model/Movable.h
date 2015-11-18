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
		m_lpFunctions = new (void (Movable::*[4])(int, float));
		m_lpFunctions[NORTH] = &Movable::MoveNorth;
		m_lpFunctions[EAST] = &Movable::MoveEast;
		m_lpFunctions[SOUTH] = &Movable::MoveSouth;
		m_lpFunctions[WEST] = &Movable::MoveWest;
	}

	void MoveNorth(int nCollisionState, float fVelocity);
	void MoveEast(int nCollisionState, float fVelocity);
	void MoveSouth(int nCollisionState, float fVelocity);
	void MoveWest(int nCollisionState, float fVelocity);

	virtual void Inertia(float fVelocity);
	void Stop();

	void Move(int nDirection, int nCollisionState, float fVelocity)
	{
		(*this.*m_lpFunctions[nDirection])(nCollisionState, fVelocity);
	}

protected:
	int m_nDirection;
	int m_fVelocity;
	
	// "m_lpFunctions is a pointer to a pointer of functions
	//	which take in an int and a float and return void."
	void (Movable::**m_lpFunctions)(int, float);

private:

};