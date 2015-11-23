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

World::~World()
{

}

void World::AddRegion(String ^ id, int x, int y)
{
	m_pRegions[id] = new Region(x, y);
}