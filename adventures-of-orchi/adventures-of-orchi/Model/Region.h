#pragma once
#include "Subdivision.h"

using namespace std;

class Region
{
public:
	Region(int id, int nWidth, int nHeight);

	~Region();

	Subdivision * GetSubdivision(int x, int y);
	Subdivision * LoadSubdivision(int x, int y);
	Subdivision * Slide(int nDirection);
	void GetDimensions(int * columns, int * rows);

	// Stairs go to another region.  Think of caves as their own
	//	one room region.
	//Stack * Go(int regionId);

	void GetLocation(int * column, int * row);

	int GetId();

protected:
	Subdivision * m_lpSubdivisions;
	int m_nCurrentSubdivisionIndex;

	int m_lpnDimensions[2];

	int m_nLocation[2];	// Player's location within the region.
	int m_nId;

private:



};
