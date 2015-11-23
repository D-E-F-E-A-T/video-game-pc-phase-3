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

//Region::Region()
//{
//	m_lpStacks = nullptr;
//	m_nCurrentStackIndex = 0;
//}

Region::~Region()
{

}

void Region::Build(float2 fScreenDimensions, const shared_ptr<DeviceResources>& deviceResources)
{
	ServiceProxy::ServiceProxy ^ proxy = ref new ServiceProxy::ServiceProxy();

	IIterable<ServiceProxy::RegionBuilderCommand ^> ^ commands = proxy->Build();

	for each (ServiceProxy::RegionBuilderCommand ^ command in commands)
	{
		float x;
		float y;


		if (command->Type == DECLARE_Region_COMMAND)
		{
			int nWidth = ((ServiceProxy::DeclareRegionCommand ^)command)->Width;
			int nHeight = ((ServiceProxy::DeclareRegionCommand ^)command)->Height;

			m_lpStacks = new Stack[nWidth * nHeight];

			m_lpnDimensions[WIDTH_INDEX] = nWidth;
			m_lpnDimensions[HEIGHT_INDEX] = nHeight;

		}
		else if (command->Type == DECLARE_SCREEN_COMMAND)
		{
			int x = ((ServiceProxy::DeclareScreenCommand ^)command)->X;
			int y = ((ServiceProxy::DeclareScreenCommand ^)command)->Y;

			m_nCurrentStackIndex = y * m_lpnDimensions[WIDTH_INDEX] + x;
		}
		if (command->Type == ADD_TREE_COMMAND)
		{
			Utils::CalculateSquareCenter(
				fScreenDimensions.x,
				fScreenDimensions.y,
				((ServiceProxy::AddTreeCommand ^)command)->X,
				((ServiceProxy::AddTreeCommand ^)command)->Y,
				&x,
				&y);

			(m_lpStacks + m_nCurrentStackIndex)->Add(LAYER_COLLIDABLES, new Tree(
				float2(x, y),
				0.f,
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
		else if (command->Type == ADD_EDGE_COMMAND)
		{
			Utils::CalculateSquareCenter(
				fScreenDimensions.x,
				fScreenDimensions.y,
				((ServiceProxy::AddEdgeCommand ^)command)->X,
				((ServiceProxy::AddEdgeCommand ^)command)->Y,
				&x,
				&y);

			(m_lpStacks + m_nCurrentStackIndex)->Add(LAYER_2D, new Edge(
				float2(x, y),
				0.f,
				float2(0.2f, 0.2f),
				((ServiceProxy::AddEdgeCommand ^)command)->Direction,
				((ServiceProxy::AddEdgeCommand ^)command)->Destination,
				deviceResources));
		}
		else if (command->Type == ADD_WATER_COMMAND)
		{
			Utils::CalculateSquareCenter(
				fScreenDimensions.x,
				fScreenDimensions.y,
				((ServiceProxy::AddWaterCommand ^)command)->X,
				((ServiceProxy::AddWaterCommand ^)command)->Y,
				&x,
				&y);

			(m_lpStacks + m_nCurrentStackIndex)->Add(LAYER_COLLIDABLES, new Water(
				float2(x, y),
				0.f,
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
		else if (command->Type == ADD_STONEWALL_COMMAND)
		{
			Utils::CalculateSquareCenter(
				fScreenDimensions.x,
				fScreenDimensions.y,
				((ServiceProxy::AddStoneWallCommand ^)command)->X,
				((ServiceProxy::AddStoneWallCommand ^)command)->Y,
				&x,
				&y);

			(m_lpStacks + m_nCurrentStackIndex)->Add(LAYER_COLLIDABLES, new StoneWall(
				float2(x, y),
				0.f,
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
		else if (command->Type == ADD_ROCK_COMMAND)
		{
			Utils::CalculateSquareCenter(
				fScreenDimensions.x,
				fScreenDimensions.y,
				((ServiceProxy::AddRockCommand ^)command)->X,
				((ServiceProxy::AddRockCommand ^)command)->Y,
				&x,
				&y);

			(m_lpStacks + m_nCurrentStackIndex)->Add(LAYER_COLLIDABLES, new Rock(
				float2(x, y),
				0.f,
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
		else if (command->Type == ADD_STAIRS_COMMAND)
		{
			Utils::CalculateSquareCenter(
				fScreenDimensions.x,
				fScreenDimensions.y,
				((ServiceProxy::AddStairsCommand ^)command)->X,
				((ServiceProxy::AddStairsCommand ^)command)->Y,
				&x,
				&y);


			(m_lpStacks + m_nCurrentStackIndex)->Add(LAYER_COLLIDABLES, new Stairs(
				float2(x, y),
				0.f,
				float2(0.75f, 0.75f),
				((ServiceProxy::AddStairsCommand ^)command)->Destination,
				deviceResources));

		}
		else if (command->Type == ADD_GRASS_COMMAND)
		{
			Utils::CalculateSquareCenter(
				fScreenDimensions.x,
				fScreenDimensions.y,
				((ServiceProxy::AddGrassCommand ^)command)->X,
				((ServiceProxy::AddGrassCommand ^)command)->Y,
				&x,
				&y);

			(m_lpStacks + m_nCurrentStackIndex)->Add(LAYER_BACKGROUND, new Grass(
				float2(x, y),
				0.f,
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
	}
}

void Region::SetScreen(int x, int y)
{
	m_nCurrentStackIndex = y * m_lpnDimensions[WIDTH_INDEX] + x;

	m_nLocation[0] = x;
	m_nLocation[1] = y;
}

Stack * Region::LoadScreen(int x, int y)
{
	return m_lpStacks + (y * m_lpnDimensions[WIDTH_INDEX] + x);
}

Stack * Region::Move(Space * currentSpace, int nDirection)
{
	if (nDirection == DOWNSTAIRS)
	{
		LoadScreen(static_cast<Portal *>(currentSpace)->GetDestination());
	}

	return nullptr;
}

// Idea: Each dungeon is a Region.
// Or each upperRegion, dungeon, cave, island 
//	is a separate Area
Stack * Region::LoadScreen(int nDestination)
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

	return LoadScreen(nColumn, nRow);
}

void Region::Move(Stack * pStack)
{
	//	m_nCurrentStackIndex = pStack->
}