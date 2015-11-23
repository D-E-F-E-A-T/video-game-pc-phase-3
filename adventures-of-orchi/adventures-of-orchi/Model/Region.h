#pragma once
#include "Subdivision.h"

using namespace std;

class Region
{
public:
	Region(String ^ strName, int nWidth, int nHeight) 
	{ 
		m_strName = strName;
		m_lpnDimensions[WIDTH_INDEX] = nWidth;
		m_lpnDimensions[HEIGHT_INDEX] = nHeight;

		*m_lpSubdivisions = new Subdivision[nWidth * nHeight];
	}

	~Region();

	Subdivision * GetSubdivision(int x, int y)
	{
		return m_lpSubdivisions[y * m_lpnDimensions[WIDTH_INDEX] + x];
	}

	void SetSubdivision(int x, int y);
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
	Stack * Go(int regionId, int x, int y);

	void GetLocation(int * column, int * row)
	{
		*column = m_nLocation[0];
		*row = m_nLocation[1];
	}


protected:
	Subdivision ** m_lpSubdivisions;


	Stack * m_lpStacks;
	int m_lpnDimensions[2];
	int m_nCurrentStackIndex;

	// For now...
	int m_nLocation[2];
	String ^ m_strName;

private:



};
