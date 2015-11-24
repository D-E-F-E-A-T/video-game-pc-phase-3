#pragma once
#include "Underground.h"
#include "Cave.h"

class Dungeon : public Underground
{
public:
	Dungeon(int id, int x, int y) :
		Underground(id, x, y) 
	{
		m_lpSubdivisions = new Cave[x * y];
	}

protected:

private:
};