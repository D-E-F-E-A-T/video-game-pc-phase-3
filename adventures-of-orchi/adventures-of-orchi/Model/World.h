#pragma once
#include "pch.h"
#include "Stack.h"
#include "Region.h"
using namespace std;

class World
{
public:
	World();

	World(String ^ strName);

	~World();

	void AddRegion(Region * pRegion);

	Region * GetRegion(int id);

	Region * LoadRegion(int id);

	Subdivision * LoadSubdivision(int x, int y);

	// Stairs go to another region.  Think of caves as their own
	//	one room region.
	Region * Go(int regionId);

protected:
	String ^ m_strName;

private:
	map<int, Region *> m_pRegions;
	Region * m_currentRegion;
};
