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
#pragma once
#include "Subdivision.h"

using namespace std;

class Region
{
public:
	Region(int id, int nWidth, int nHeight, int nEntryX, int nEntryY);

	~Region();

	Subdivision * GetSubdivision(int x, int y);
	Subdivision * LoadSubdivision(int x, int y);
	Subdivision * Slide(int nDirection);
	void GetDimensions(int * columns, int * rows);

	// Stairs go to another region.  Think of caves as their own
	//	one room region.
	//Stack * Go(int regionId);

	void GetLocation(int * column, int * row);
	void GetEntry(int * x, int * y);

	int GetId();

protected:
	Subdivision * m_lpSubdivisions;
	int m_nCurrentSubdivisionIndex;

	int m_lpnDimensions[2];

	int m_nLocation[2];	// Player's location within the region.
	int m_nId;
	int m_nEntryX;
	int m_nEntryY;

private:



};
