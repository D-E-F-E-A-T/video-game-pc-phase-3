#pragma once
#include "pch.h"
#include "..\Model\Stack.h"
using namespace std;

class World
{
public:
	World();
	~World();

	void Build(
		float2 fScreenDimensions, 
		const shared_ptr<DeviceResources>& deviceResources);

	void SetScreen(int x, int y);
	Stack * LoadScreen(int x, int y);
	Stack * LoadScreen(int nDirection);
	Stack * Move(int nDirection);
	Stack * Move(Space * currentSpace, int nDirection);
	void Move(Stack *);
	void GetDimensions(int * columns, int * rows)
	{
		*columns = m_lpnDimensions[0];
		*rows = m_lpnDimensions[1];
	}

	void GetLocation(int * column, int * row)
	{
		*column = m_nLocation[0];
		*row = m_nLocation[1];
	}

protected:

private:
	Stack * m_lpStacks;
	int m_lpnDimensions[2];
	int m_nCurrentStackIndex;

	// For now...
	int m_nLocation[2];


};
