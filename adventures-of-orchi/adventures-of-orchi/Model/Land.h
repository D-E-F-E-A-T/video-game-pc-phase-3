#pragma once
#include "Onground.h"
#include "Lot.h"

class Land : public Onground
{
public:
	Land(int id, int x, int y) :
		Onground(id, x, y) 
	{
		m_lpSubdivisions = new Lot[x * y];
	}

protected:

private:
};
