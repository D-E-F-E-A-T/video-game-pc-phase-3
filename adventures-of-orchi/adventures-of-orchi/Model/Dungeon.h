#pragma once
#include "Underground.h"
#include "Cave.h"

class Dungeon : public Underground
{
public:
	Dungeon(int id, int x, int y, int nEntryX, int nEntryY, int nRed, int nGreen, int nBlue) :
		Underground(id, x, y, nEntryX, nEntryY) 
	{
		m_lpSubdivisions = new Cave[x * y];

		for (int i = 0; i < x * y; i++)
		{
			(m_lpSubdivisions + i)->SetColor(nRed, nGreen, nBlue);
		}
	}

protected:

private:
};