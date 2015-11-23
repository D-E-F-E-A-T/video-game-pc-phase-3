#pragma once
#include "Onground.h"

class Land : public Onground
{
public:
	Land(String ^ strName, int x, int y) :
		OnGround(strName, x, y) {};

protected:

private:
};
