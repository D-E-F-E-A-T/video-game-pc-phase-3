#pragma once
#include "Immovable.h"
#include "Player.h"

class Portal : public Immovable
{
public:
	Portal(
		float2 pfLocationRatio, 
		float fRotationInRadians,
		float2 pfDimensionRatio, 
		int nDestination,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources) :
		Immovable(
			pfLocationRatio, 
			fRotationInRadians,
			pfDimensionRatio, 
			bIsVisible,
			true, 
			true, 
			deviceResources)
	{
		m_nDestination = nDestination;
	}


	int GetDestination() { return m_nDestination; }

protected:
	int m_nDestination;

private:

};