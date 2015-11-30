#pragma once
#include "Onground.h"
#include "Lot.h"

class Land : public Onground
{
public:
	Land(int id, int nColumns, int nRows, int nEntryX, int nEntryY) :
		Onground(id, nColumns, nRows, nEntryX, nEntryY) 
	{
		m_lpSubdivisions = new Lot[nColumns * nRows];
	}

protected:

private:
};
