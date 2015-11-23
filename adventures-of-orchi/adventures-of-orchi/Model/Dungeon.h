#pragma once
#include "Underground.h"

class Dungeon : public Underground
{
public:
	Dungeon(String ^ strName, int x, int y) :
		Underground(strName, x, y) {};

protected:

private:
};