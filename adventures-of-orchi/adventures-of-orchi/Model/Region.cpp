/*
Copyright 2016 Richard Bernardino

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
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

Region::Region(int id, int nWidth, int nHeight, int nEntryX, int nEntryY)
{
	m_nId = id;
	m_lpnDimensions[WIDTH_INDEX] = nWidth;
	m_lpnDimensions[HEIGHT_INDEX] = nHeight;

	m_nEntryX = nEntryX;
	m_nEntryY = nEntryY;
}

Region::~Region()
{

}


Subdivision * Region::LoadSubdivision(int x, int y)
{
	m_nCurrentSubdivisionIndex = y * m_lpnDimensions[WIDTH_INDEX] + x;

	m_nLocation[0] = x;
	m_nLocation[1] = y;

	return (m_lpSubdivisions + (y * m_lpnDimensions[WIDTH_INDEX] + x));
}

Subdivision * Region::Slide(int nDirection)
{
	int nColumn = m_nCurrentSubdivisionIndex % m_lpnDimensions[WIDTH_INDEX];
	int nRow = m_nCurrentSubdivisionIndex / m_lpnDimensions[WIDTH_INDEX];

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

	m_nCurrentSubdivisionIndex = nRow * m_lpnDimensions[WIDTH_INDEX] + nColumn;

#ifdef _DEBUG
	char buffer[32];
	sprintf_s(buffer, "Moving to screen %d %d\n", nColumn, nRow);
	OutputDebugStringA(buffer);
#endif // _DEBUG

	return LoadSubdivision(nColumn, nRow);
}

void Region::GetLocation(int * column, int * row)
{
	*column = m_nLocation[0];
	*row = m_nLocation[1];
}

int Region::GetId() 
{ 
	return m_nId; 
}

void Region::GetDimensions(int * columns, int * rows)
{
	*columns = m_lpnDimensions[0];
	*rows = m_lpnDimensions[1];
}

Subdivision * Region::GetSubdivision(int x, int y)
{
	return m_lpSubdivisions + (y * m_lpnDimensions[WIDTH_INDEX] + x);
}

void Region::GetEntry(int * x, int * y)
{
	*x = this->m_nEntryX;
	*y = this->m_nEntryY;
}