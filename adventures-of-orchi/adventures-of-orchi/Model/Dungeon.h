#pragma once
#include "Underground.h"
#include "Cave.h"

class Dungeon : public Underground
{
public:
	Dungeon(int id, int columns, int rows, int nEntryX, int nEntryY) :
		Underground(id, columns, rows, nEntryX, nEntryY) 
	{
		m_lpSubdivisions = new Cave[columns * rows];

/*
		for (int i = 0; i < x * y; i++)
		{
			(m_lpSubdivisions + i)->SetColor(nRed, nGreen, nBlue);
		}
*/
	}

protected:

private:
};