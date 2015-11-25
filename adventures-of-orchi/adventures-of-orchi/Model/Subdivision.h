#pragma once
#include "Stack.h"
#include "..\Grid.h"

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

	virtual void Render(
		float lpfScreenDimensions[2],
		Grid * lpGrid,
		const shared_ptr<DeviceResources>& deviceResources) = 0;

protected:
	Stack * m_lpStack;

//	int m_lpnDimensions[2];
	int m_nCurrentStackIndex;

private:
};
