#pragma once
#include "Region.h"

class Onground : public Region
{
public:
	Onground(int id, int nColumns, int nRows, int nEntryX, int nEntryY) :
		Region(id, nColumns, nRows, nEntryX, nEntryY) {}

protected:

private:
};