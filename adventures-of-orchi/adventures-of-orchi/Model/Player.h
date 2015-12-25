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
#include "..\Grid.h"
#include "..\Constants.h"
#include "Character.h"
#include "Texture.h"


class Player : public Character
{
public:
	Player(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources)
		: Character(
			pfLocationRatio,
			fRotationInRadians,
			pfDimensions,
			true,
			nullptr,
			deviceResources)
	{
		m_nPreviousMoveDirection = CENTER;
		m_pRenderable = new Texture("link.dds", m_deviceResources);

		m_lpSkipFunctions = new (void (Player::*[4])(float2));
		m_lpSkipFunctions[NORTH] = &Player::SkipNorth;
		m_lpSkipFunctions[EAST] = &Player::SkipEast;
		m_lpSkipFunctions[SOUTH] = &Player::SkipSouth;
		m_lpSkipFunctions[WEST] = &Player::SkipWest;
	}

	~Player()
	{
		delete[] m_lpSkipFunctions;
	}

	void SkipNorth(float2);
	void SkipEast(float2);
	void SkipSouth(float2);
	void SkipWest(float2);


	void Skip(int nDirection, float2 fScreenDimensions)
	{
		(*this.*m_lpSkipFunctions[nDirection])(fScreenDimensions);
	}

protected:

private:
	int m_pGridLocation[NUM_DIMENSIONS];
	int m_nUnitsPerGridSquare[NUM_DIMENSIONS];

	void (Player::**m_lpSkipFunctions)(float2);
	int m_nPreviousMoveDirection;
};