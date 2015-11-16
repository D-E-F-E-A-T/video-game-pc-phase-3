#pragma once
#include "Immovable.h"
#include "Player.h"

class Portal : public Immovable
{
public:
	Portal(
		float2 pfLocationRatio, 
		float2 pfDimensionRatio, 
		int nDestination,
		const shared_ptr<DeviceResources>& deviceResources) :
		Immovable(
			pfLocationRatio, 
			pfDimensionRatio, 
			false, 
			true, 
			true, 
			deviceResources)
	{
		m_nDestination = nDestination;
	}

	bool IsOverlapping(Player * pPlayer, Space * pSpace) {}

	int GetDestination() { return m_nDestination; }

	virtual void Act() = 0;

protected:
	int m_nDestination;

private:

};