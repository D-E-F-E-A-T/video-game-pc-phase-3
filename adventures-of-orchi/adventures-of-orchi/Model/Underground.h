#pragma once
#include "Region.h"

class Underground : public Region
{
public:
	Underground(int id, int nColumns, int nRows, int nEntryX, int nEntryY) :
		Region(id, nColumns, nRows, nEntryX, nEntryY) {}

protected:

private:
};