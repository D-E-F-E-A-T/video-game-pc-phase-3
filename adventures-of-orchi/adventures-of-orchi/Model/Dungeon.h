#pragma once
#include "Underground.h"
#include "Cave.h"

class Dungeon : public Underground
{
public:
	Dungeon(int id, int x, int y, int nEntryX, int nEntryY, String ^ strColor) :
		Underground(id, x, y, nEntryX, nEntryY) 
	{
		m_lpSubdivisions = new Cave[x * y];
		m_strColor = strColor;
	}

	String ^ GetColor() { return m_strColor; }

protected:
	String ^ m_strColor;

private:
};