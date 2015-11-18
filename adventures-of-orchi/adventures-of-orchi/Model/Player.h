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
	}



	void SkipNorth();
	void SkipEast();
	void SkipSouth();
	void SkipWest();

	// The distance between the Player and itself is 0.
	// The case would be different if there were other Players.
	virtual float CalculateDistance(Space * space) { return 10000000.f; }


protected:

private:
	int m_pGridLocation[NUM_DIMENSIONS];
	int m_nUnitsPerGridSquare[NUM_DIMENSIONS];


	int m_nPreviousMoveDirection;
};