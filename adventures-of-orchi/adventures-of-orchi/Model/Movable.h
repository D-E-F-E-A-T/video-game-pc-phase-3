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
			pfDimensions,
			bIsVisible,
			false,
			true,
			deviceResources)
	{
		m_lpMoveFunctions = new (void (Movable::*[4])(int, float));
		m_lpMoveFunctions[NORTH] = &Movable::MoveNorth;
		m_lpMoveFunctions[EAST] = &Movable::MoveEast;
		m_lpMoveFunctions[SOUTH] = &Movable::MoveSouth;
		m_lpMoveFunctions[WEST] = &Movable::MoveWest;
	}

	~Movable()
	{
		delete [] m_lpMoveFunctions;
	}

	void MoveNorth(int nCollisionState, float fVelocity);
	void MoveEast(int nCollisionState, float fVelocity);
	void MoveSouth(int nCollisionState, float fVelocity);
	void MoveWest(int nCollisionState, float fVelocity);

	virtual void Inertia(float fVelocity);
	void Stop();

	void Move(int nDirection, int nCollisionState, float fVelocity)
	{
		(*this.*m_lpMoveFunctions[nDirection])(nCollisionState, fVelocity);
	}

protected:
	int m_nDirection;
	int m_fVelocity;
	
	// "m_lpFunctions is a pointer to a pointer of functions
	//	which take in an int and a float and return void."
	void (Movable::**m_lpMoveFunctions)(int, float);

private:

};