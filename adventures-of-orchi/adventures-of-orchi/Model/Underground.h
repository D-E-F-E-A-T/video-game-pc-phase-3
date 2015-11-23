#pragma once
#include "Region.h"

class Underground : public Region
{
public:
	Underground(String ^ strName, int x, int y) :
		Region(strName, x, y) {}

protected:

private:
};