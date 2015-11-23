#include "pch.h"
#include "Constants.h"
#include "WorldFactory.h"
#include "Land.h"
#include "Edge.h"
#include "Dungeon.h"
#include "Grass.h"
#include "Rock.h"
#include "Stairs.h"
#include "StoneWall.h"
#include "Tree.h"
#include "Water.h"
#include "..\Utils.h"

using namespace Windows::Foundation::Collections;
using namespace std;

World * WorldFactory::Build(float2 fScreenDimensions, const shared_ptr<DeviceResources>& deviceResources)
{
	World * retVal = nullptr;

	ServiceProxy::ServiceProxy ^ proxy = ref new ServiceProxy::ServiceProxy();

	IIterable<ServiceProxy::BuildCommand ^> ^ commands = proxy->Build();

	String ^ strCurrentRegionId;

/*
	AddEdgeCommand = 0
		AddGrassCommand = 2
		AddRockCommand = 3
		AddStairsCommand = 4
		AddStoneWallCommand = 5
		AddTreeCommand = 6
		AddWaterCommand = 7
		DeclareCaveCommand = 8
		DeclareDungeonCommand = 9
		DeclareLandCommand = 10
		DeclareLotCommand = 11
		DeclareWorldCommand = 12
*/

	Subdivision * pCurrentSubdivision = nullptr;

	for each (ServiceProxy::BuildCommand ^ command in commands)
	{
		float x;
		float y;

		if (command->Type == ADD_EDGE_COMMAND)
		{
			Utils::CalculateSquareCenter(
				fScreenDimensions.x,
				fScreenDimensions.y,
				((ServiceProxy::AddEdgeCommand ^)command)->X,
				((ServiceProxy::AddEdgeCommand ^)command)->Y,
				&x,
				&y);

			pCurrentSubdivision->Set(LAYER_2D,
				new Edge(
					float2(x, y),
					0.f,
					float2(0.2f, 0.2f),
					((ServiceProxy::AddEdgeCommand ^)command)->Direction,
					((ServiceProxy::AddEdgeCommand ^)command)->Destination,
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

			pCurrentSubdivision->Set(LAYER_BACKGROUND,
				new Grass(
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

			pCurrentSubdivision->Set(LAYER_COLLIDABLES,
				new Rock(
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


			pCurrentSubdivision->Set(LAYER_COLLIDABLES,
				new Stairs(
					float2(x, y),
					0.f,
					float2(0.75f, 0.75f),
					((ServiceProxy::AddStairsCommand ^)command)->Destination,
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

			pCurrentSubdivision->Set(LAYER_COLLIDABLES,
				new StoneWall(
					float2(x, y),
					0.f,
					float2(1.f, 1.f),
					true,
					deviceResources));
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

			pCurrentSubdivision->Set(LAYER_COLLIDABLES,
				new Tree(
					float2(x, y),
					0.f,
					float2(1.f, 1.f),
					true,
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

			pCurrentSubdivision->Set(LAYER_COLLIDABLES,
				new Water(
					float2(x, y),
					0.f,
					float2(1.f, 1.f),
					true,
					deviceResources));
		}
		else if (command->Type == DECLARE_CAVE_COMMAND)
		{
			String ^ strName = ((ServiceProxy::DeclareCaveCommand ^)command)->Name;

			int x = ((ServiceProxy::DeclareCaveCommand ^)command)->X;
			int y = ((ServiceProxy::DeclareCaveCommand ^)command)->Y;

			Region * region = retVal->GetRegion(strName);
			pCurrentSubdivision = region->GetSubdivision(x, y);

		}
		else if (command->Type == DECLARE_DUNGEON_COMMAND)
		{
			String ^ strName = ((ServiceProxy::DeclareDungeonCommand ^)command)->Name;
			int x = ((ServiceProxy::DeclareDungeonCommand ^)command)->X;
			int y = ((ServiceProxy::DeclareDungeonCommand ^)command)->Y;

			retVal->AddRegion(new Dungeon(strName, x, y));
		}
		else if (command->Type == DECLARE_LAND_COMMAND)
		{
			String ^ strName = ((ServiceProxy::DeclareLandCommand ^)command)->Name;
			int x = ((ServiceProxy::DeclareLandCommand ^)command)->X;
			int y = ((ServiceProxy::DeclareLandCommand ^)command)->Y;

			retVal->AddRegion(new Land(strName, x, y));
		}
		else if (command->Type == DECLARE_LOT_COMMAND)
		{
			String ^ strName = ((ServiceProxy::DeclareLotCommand ^)command)->RegionName;
			int x = ((ServiceProxy::DeclareLotCommand ^)command)->X;
			int y = ((ServiceProxy::DeclareLotCommand ^)command)->Y;

			Region * region = retVal->GetRegion(strName);
			pCurrentSubdivision = region->GetSubdivision(x, y);
		}
		else if (command->Type == DECLARE_WORLD_COMMAND)
		{
			String ^ strName = ((ServiceProxy::DeclareWorldCommand ^)command)->Name;

			retVal = new World(strName);
		}
	}

	return retVal;
}