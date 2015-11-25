#pragma once
#include "Region.h"

class Onground : public Region
{
public:
	Onground(int id, int x, int y, int nEntryX, int nEntryY) :
		Region(id, x, y, nEntryX, nEntryY) {}

protected:

private:
};