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
#include "Underground.h"
#include "Cave.h"

class Dungeon : public Underground
{
public:
	Dungeon(int id, int columns, int rows, int nEntryX, int nEntryY) :
		Underground(id, columns, rows, nEntryX, nEntryY) 
	{
		m_lpSubdivisions = new Cave[columns * rows];

/*
		for (int i = 0; i < x * y; i++)
		{
			(m_lpSubdivisions + i)->SetColor(nRed, nGreen, nBlue);
		}
*/
	}

protected:

private:
};