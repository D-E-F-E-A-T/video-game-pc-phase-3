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
			deviceResources)
	{
		m_nPreviousMoveDirection = CENTER;
		m_pRenderable = new Texture("link.dds", m_deviceResources);

		m_lpSkipFunctions = new (void (Player::*[4])());
		m_lpSkipFunctions[NORTH] = &Player::SkipNorth;
		m_lpSkipFunctions[EAST] = &Player::SkipEast;
		m_lpSkipFunctions[SOUTH] = &Player::SkipSouth;
		m_lpSkipFunctions[WEST] = &Player::SkipWest;
	}

	~Player()
	{
		delete[] m_lpSkipFunctions;
	}

	void SkipNorth();
	void SkipEast();
	void SkipSouth();
	void SkipWest();


	void Skip(int nDirection)
	{
		(*this.*m_lpSkipFunctions[nDirection])();
	}

protected:

private:
	int m_pGridLocation[NUM_DIMENSIONS];
	int m_nUnitsPerGridSquare[NUM_DIMENSIONS];

	void (Player::**m_lpSkipFunctions)();
	int m_nPreviousMoveDirection;
};