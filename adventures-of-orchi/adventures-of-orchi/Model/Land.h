#pragma once
#include "Onground.h"
#include "Lot.h"

class Land : public Onground
{
public:
	Land(int id, int x, int y, int nEntryX, int nEntryY) :
		Onground(id, x, y, nEntryX, nEntryY) 
	{
		m_lpSubdivisions = new Lot[x * y];
	}

protected:

private:
};
