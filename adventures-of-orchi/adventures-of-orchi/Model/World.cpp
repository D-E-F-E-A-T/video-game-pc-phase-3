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
#include "World.h"
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

World::World()
{
}

World::World(String ^ strName)
{
	m_strName = strName;
}

World::~World()
{

}

void World::AddRegion(Region * pRegion)
{
	m_pRegions[pRegion->GetId()] = pRegion;
}

Region * World::Go(int regionId)
{
	return m_pRegions[regionId];
}

Region * World::GetRegion(int id)
{
	return m_pRegions[id];
}

Region * World::LoadRegion(int id)
{
	m_currentRegion = m_pRegions[id];
	return m_currentRegion;
}

Subdivision * World::LoadSubdivision(int x, int y)
{
	return m_currentRegion->LoadSubdivision(x, y);
}