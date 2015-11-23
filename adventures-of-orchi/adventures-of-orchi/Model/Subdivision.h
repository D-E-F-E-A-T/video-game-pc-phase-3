#pragma once
#include "Stack.h"

class Subdivision
{
public:
	Subdivision()
	{
		m_lpStack = new Stack();
	}

	void Set(int layerId, Space * pSpace)
	{
		m_lpStack->Add(layerId, pSpace);
	}

	Stack * GetStack() { return m_lpStack; }

protected:
	Stack * m_lpStack;
	int m_lpnDimensions[2];
	int m_nCurrentStackIndex;

private:
};
