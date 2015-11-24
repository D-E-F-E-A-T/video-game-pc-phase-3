#pragma once
#include "pch.h"
#include "Stack.h"
#include "Region.h"
using namespace std;

class World
{
public:
	World();

	World(String ^ strName)
	{
		m_strName = strName;
	}

	~World();

	void AddRegion(Region * pRegion);

	Region * GetRegion(int id)
	{
		return m_pRegions[id];
	}

	void LoadRegion(int id)
	{
		m_currentRegion = m_pRegions[id];
	}

	Stack * LoadSubdivision(int x, int y)
	{
		return m_currentRegion->LoadSubdivision(x, y);
	}

	/*void SetScreen(int x, int y);
	Stack * LoadScreen(int x, int y);
	Stack * LoadScreen(int nDirection);
	Stack * Slide(int nDirection);
	Stack * Move(Space * currentSpace, int nDirection);
	void Move(Stack *);
	void GetDimensions(int * columns, int * rows)
	{
		*columns = m_lpnDimensions[0];
		*rows = m_lpnDimensions[1];
	}*/

	// Stairs go to another region.  Think of caves as their own
	//	one room region.
	Region * Go(int regionId);

	//void GetLocation(int * column, int * row)
	//{
	//	*column = m_nLocation[0];
	//	*row = m_nLocation[1];
	//}

protected:
	String ^ m_strName;

private:
	map<int, Region *> m_pRegions;
	Region * m_currentRegion;
//	Stack * m_lpStacks;
	//int m_lpnDimensions[2];
	//int m_nCurrentStackIndex;

	// For now...
	//int m_nLocation[2];
//	int m_nCurrentStack;


};
