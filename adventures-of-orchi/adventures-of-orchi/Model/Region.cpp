#include "pch.h"
#include "Region.h"
#include "Utils.h"
#include "Model\Tree.h"
#include "Model\Edge.h"
#include "Model\Water.h"
#include "Model\StoneWall.h"
#include "Model\Rock.h"
#include "Model\Stairs.h"
#include "Model\Grass.h"

using namespace Windows::Foundation::Collections;
using namespace std;

Region::~Region()
{

}


Stack * Region::LoadSubdivision(int x, int y)
{
	m_nCurrentStackIndex = y * m_lpnDimensions[WIDTH_INDEX] + x;

	m_nLocation[0] = x;
	m_nLocation[1] = y;

	return (m_lpSubdivisions + (y * m_lpnDimensions[WIDTH_INDEX] + x))->GetStack();
}

Stack * Region::Move(Space * currentSpace, int nDirection)
{
	//if (nDirection == DOWNSTAIRS)
	//{
	//	LoadScreen(static_cast<Portal *>(currentSpace)->GetDestination());
	//}

	return nullptr;
}

// Idea: Each dungeon is a Region.
// Or each upperRegion, dungeon, cave, island 
//	is a separate Area
Stack * Region::LoadSubdivision(int nDestination)
{
	return nullptr;
}

Stack * Region::Slide(int nDirection)
{
	int nColumn = m_nCurrentStackIndex % m_lpnDimensions[WIDTH_INDEX];
	int nRow = m_nCurrentStackIndex / m_lpnDimensions[WIDTH_INDEX];

	if (nDirection == NORTH)
	{
		nRow -= 1;
	}
	else if (nDirection == EAST)
	{
		nColumn += 1;
	}
	else if (nDirection == SOUTH)
	{
		nRow += 1;
	}
	else if (nDirection == WEST)
	{
		nColumn -= 1;
	}

	m_nLocation[0] = nColumn;
	m_nLocation[1] = nRow;

	m_nCurrentStackIndex = nRow * m_lpnDimensions[WIDTH_INDEX] + nColumn;

#ifdef _DEBUG
	char buffer[32];
	sprintf_s(buffer, "Moving to screen %d %d\n", nColumn, nRow);
	OutputDebugStringA(buffer);
#endif // _DEBUG

	return LoadSubdivision(nColumn, nRow);
}

void Region::Move(Stack * pStack)
{
	//	m_nCurrentStackIndex = pStack->
}