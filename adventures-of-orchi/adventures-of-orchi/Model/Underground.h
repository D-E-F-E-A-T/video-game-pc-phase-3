#pragma once
#include "Region.h"

class Underground : public Region
{
public:
	Underground(int id, int x, int y, int nEntryX, int nEntryY) :
		Region(id, x, y, nEntryX, nEntryY) {}

protected:

private:
};