#pragma once
#include "Region.h"

class Onground : public Region
{
public:
	Onground(String ^ strName, int x, int y) :
		Region(strName, x, y) {}

protected:

private:
};