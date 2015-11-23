#pragma once
#include "Stack.h"

class Subdivision
{
public:
	void Set(int layerId, int x, int y, Space * pSpace);

protected:
	Stack * m_lpStacks;
	int m_lpnDimensions[2];
	int m_nCurrentStackIndex;

private:
};
