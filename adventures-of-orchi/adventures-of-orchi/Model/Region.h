#pragma once
#include "Subdivision.h"

using namespace std;

class Region
{
public:
	Region(int id, int nWidth, int nHeight) 
	{ 
		m_nId = id;
		m_lpnDimensions[WIDTH_INDEX] = nWidth;
		m_lpnDimensions[HEIGHT_INDEX] = nHeight;
	}

	~Region();

	Subdivision * GetSubdivision(int x, int y)
	{
		return m_lpSubdivisions + (y * m_lpnDimensions[WIDTH_INDEX] + x);
	}

	Stack * LoadSubdivision(int x, int y);
	Stack * LoadSubdivision(int nDirection);
	Stack * Slide(int nDirection);
	Stack * Move(Space * currentSpace, int nDirection);
	void Move(Stack *);
	void GetDimensions(int * columns, int * rows)
	{
		*columns = m_lpnDimensions[0];
		*rows = m_lpnDimensions[1];
	}

	// Stairs go to another region.  Think of caves as their own
	//	one room region.
	Stack * Go(int regionId);

	void GetLocation(int * column, int * row)
	{
		*column = m_nLocation[0];
		*row = m_nLocation[1];
	}

	int GetId() { return m_nId; }

protected:
	Subdivision * m_lpSubdivisions;
	int m_nCurrentStackIndex;

	int m_lpnDimensions[2];

	int m_nLocation[2];	// Player's location within the region.
	int m_nId;

private:



};
