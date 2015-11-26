#pragma once
#include "Onground.h"
#include "Lot.h"

class Land : public Onground
{
public:
	Land(int id, int x, int y, int nEntryX, int nEntryY, int nRed, int nGreen, int nBlue) :
		Onground(id, x, y, nEntryX, nEntryY) 
	{
		m_lpSubdivisions = new Lot[x * y];

		for (int i = 0; i < x * y; i++)
		{
			(m_lpSubdivisions + i)->SetColor(nRed, nGreen, nBlue);
		}
	}

protected:

private:
};
