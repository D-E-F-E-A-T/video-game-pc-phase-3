#include "pch.h"
#include "NarrowCollisionStrategy.h"
#include "Model\Player.h"
#include "MathUtils.h"
#include <iostream>
#include <Windows.h>
#include "..\Sprites\SpriteUtils.h"
#include "Utils.h"

// @see http://www.gamedev.net/page/resources/_/technical/directx-and-xna/pixel-perfect-collision-detection-in-directx-r2939
// @see http://gamedev.stackexchange.com/questions/27690/reading-from-a-staging-2d-texture-array-in-directx10
// @see http://www.directxtutorial.com/Lesson.aspx?lessonid=11-4-5
// @see http://www.cleoag.ru/2013/05/12/directx-texture-hbitmap/
NarrowCollisionStrategy::NarrowCollisionStrategy()
{

}

NarrowCollisionStrategy::~NarrowCollisionStrategy()
{

}

int NarrowCollisionStrategy::Detect(
	ID3D11DeviceContext2 * context,
	ID3D11Device2 * device,
	Player * pPlayer,
	Space * collided, // std::list<Space *> * collided,
	Grid * grid, // Player location is the coordinates of the center of the sprite.
	int * intersectRect,
	float2 screenDimensions)
{
	bool bIntersection = false;

	uint8_t * playerPixels = pPlayer->GetPixels();
	uint8_t * obstaclePixels = collided->GetPixels();

	int * rawPlayerDimensions = pPlayer->GetTextureDimensions();
	int * rawObstacleDimensions = collided->GetTextureDimensions();

#ifdef DUMP_PIXELS
	DumpPixels(rawPlayerDimensions[0], rawPlayerDimensions[1], playerPixels);
	DumpPixels(rawObstacleDimensions[0], rawObstacleDimensions[1], obstaclePixels);
#endif // DUMP_PIXELS

	int playerTopLeft[2];

	// Should really use the dimensions of the sprite.
	//	For now, using the dimensions of the grid space.
	playerTopLeft[HORIZONTAL_AXIS] = (int)(pPlayer->GetLocationRatio().x * screenDimensions.x - grid->GetColumnWidth() / 2.f);
	playerTopLeft[VERTICAL_AXIS] = (int)(pPlayer->GetLocationRatio().y * screenDimensions.y - grid->GetRowHeight() / 2.f);

	int renderedSpriteDimensions[2];
	float obstacleCenterLocation[2];

	obstacleCenterLocation[HORIZONTAL_AXIS] = collided->GetLocationRatio().x * screenDimensions.x;
	obstacleCenterLocation[VERTICAL_AXIS] = collided->GetLocationRatio().y * screenDimensions.y;

	// These are relative to the rendered sprite.
	//	Take into consideration the actual screen dimensions.
	renderedSpriteDimensions[WIDTH_INDEX] = (int)grid->GetColumnWidth();
	renderedSpriteDimensions[HEIGHT_INDEX] = (int)grid->GetRowHeight();

	// Right now, all obstacles are assumed to occupy exactly one grid space.
	int obstacleTopLeft[2];
	obstacleTopLeft[HORIZONTAL_AXIS] = 
		(int)obstacleCenterLocation[HORIZONTAL_AXIS] -
		(renderedSpriteDimensions[WIDTH_INDEX] >> 1);

	obstacleTopLeft[VERTICAL_AXIS] = 
		(int)obstacleCenterLocation[VERTICAL_AXIS] -
		(renderedSpriteDimensions[HEIGHT_INDEX] >> 1);

	bIntersection = IntersectRect(
		playerTopLeft,
		obstacleTopLeft,
		renderedSpriteDimensions[WIDTH_INDEX],
		renderedSpriteDimensions[HEIGHT_INDEX],
		intersectRect);


	if (bIntersection == true)
	{
		int intersectionWidth = abs(intersectRect[INTERSECTION_LEFT] - intersectRect[INTERSECTION_RIGHT]);
		int intersectionHeight = abs(intersectRect[INTERSECTION_TOP] - intersectRect[INTERSECTION_BOTTOM]);

		for (int row = 0; row < intersectionHeight; row++)
		{
			for (int column = 0; column < intersectionWidth; column++)
			{

				// These coordinates are relative to the whole screen.
				int playerIntersectionHorizontalOffset = intersectRect[0] - playerTopLeft[0] + column;
				int playerIntersectionVerticalOffset = intersectRect[2] - playerTopLeft[1] + row;

				// These coordinates are relative to the whole screen.
				int obstacleIntersectionHorizontalOffset = intersectRect[0] - obstacleTopLeft[0] + column;
				int obstacleIntersectionVerticalOffset = intersectRect[2] - obstacleTopLeft[1] + row;


				float playerPixelNormalizedLocation[2];
				int playerPixelRawCoordinate[2];
				float obstaclePixelNormalizedLocation[2];
				int obstaclePixelRawCoordinate[2];

				// Relative to the raw sprite dimensions (0, 1.0f)
				playerPixelNormalizedLocation[HORIZONTAL_AXIS] =
					(float)playerIntersectionHorizontalOffset / (float)renderedSpriteDimensions[HORIZONTAL_AXIS];

				// Relative to the raw sprite dimensions (0, 1.0f)
				playerPixelNormalizedLocation[VERTICAL_AXIS] =
					(float)playerIntersectionVerticalOffset / (float)renderedSpriteDimensions[VERTICAL_AXIS];

				// Relative to the raw sprite dimensions (0, 1.0f)
				obstaclePixelNormalizedLocation[HORIZONTAL_AXIS] =
					(float)obstacleIntersectionHorizontalOffset / (float)renderedSpriteDimensions[HORIZONTAL_AXIS];

				// Relative to the raw sprite dimensions (0, 1.0f)
				obstaclePixelNormalizedLocation[VERTICAL_AXIS] =
					(float)((float)obstacleIntersectionVerticalOffset / (float)renderedSpriteDimensions[VERTICAL_AXIS]);

				playerPixelRawCoordinate[HORIZONTAL_AXIS] =
					(int)(playerPixelNormalizedLocation[HORIZONTAL_AXIS] * (float)rawPlayerDimensions[HORIZONTAL_AXIS]);

				playerPixelRawCoordinate[VERTICAL_AXIS] =
					(int)(playerPixelNormalizedLocation[VERTICAL_AXIS] * (float)rawPlayerDimensions[VERTICAL_AXIS]);

				obstaclePixelRawCoordinate[HORIZONTAL_AXIS] =
					(int)(obstaclePixelNormalizedLocation[HORIZONTAL_AXIS] * (float)rawObstacleDimensions[HORIZONTAL_AXIS]);

				obstaclePixelRawCoordinate[VERTICAL_AXIS] =
					(int)((float)obstaclePixelNormalizedLocation[VERTICAL_AXIS] * (float)rawObstacleDimensions[VERTICAL_AXIS]);
			
				int rawPlayerPixelIndex =
					(playerPixelRawCoordinate[VERTICAL_AXIS] * rawPlayerDimensions[HORIZONTAL_AXIS]) +
					playerPixelRawCoordinate[HORIZONTAL_AXIS];

				int rawObstaclePixelIndex =
					(obstaclePixelRawCoordinate[VERTICAL_AXIS] * rawObstacleDimensions[HORIZONTAL_AXIS]) +
					obstaclePixelRawCoordinate[HORIZONTAL_AXIS];

				uint32_t * dPtrPlayer = reinterpret_cast<uint32_t*>(playerPixels);
				uint32_t * dPtrObstacle = reinterpret_cast<uint32_t*>(obstaclePixels);

				int playerResult =
					(dPtrPlayer[rawPlayerPixelIndex] & 0xff000000) >> 24;

				int obstacleResult =
					(dPtrObstacle[rawObstaclePixelIndex] & 0xff000000) >> 24;

				if (playerResult > 0 && obstacleResult > 0)
				{				
					return COLLISION;
				}
			}
		}

		return INTERSECTION;
	}
	else
	{
		return NO_INTERSECTION;
	}

	return NO_INTERSECTION;
}





// Project the coordinates of each rectangle to the
//	x and y axes. The second and third values will be 
//	the intersection.
bool NarrowCollisionStrategy::IntersectRect(
	int * playerTopLeft,
	int * obstacleTopLeft,
	int width,
	int height,
	int * retVal)
{
	int horizontalCoords[4];
	int verticalCoords[4];

	// Check if there is any intersection.
	bool horizontalOverlap = true;
	bool verticalOverlap = true;

	horizontalCoords[0] = playerTopLeft[0];
	horizontalCoords[1] = playerTopLeft[0] + width;
	horizontalCoords[2] = obstacleTopLeft[0];
	horizontalCoords[3] = obstacleTopLeft[0] + width;

	verticalCoords[0] = playerTopLeft[1];
	verticalCoords[1] = playerTopLeft[1] + height;
	verticalCoords[2] = obstacleTopLeft[1];
	verticalCoords[3] = obstacleTopLeft[1] + height;

	if (horizontalCoords[0] <= horizontalCoords[2])
	{
		if (horizontalCoords[1] < horizontalCoords[2])
		{
			horizontalOverlap = false;
		}
	}

	if (horizontalOverlap == true)
	{
		if (horizontalCoords[2] <= horizontalCoords[0])
		{
			if (horizontalCoords[3] < horizontalCoords[0])
			{
				horizontalOverlap = false;
			}
		}
	}

	if (verticalCoords[0] <= verticalCoords[2])
	{
		if (verticalCoords[1] < verticalCoords[2])
		{
			verticalOverlap = false;
		}
	}

	if (verticalOverlap == true)
	{
		if (verticalCoords[2] <= verticalCoords[0])
		{
			if (verticalCoords[3] < verticalCoords[0])
			{
				verticalOverlap = false;
			}
		}
	}


	if (verticalOverlap == true && horizontalOverlap == true)
	{
		::InsertionSortI(horizontalCoords, 4);
		::InsertionSortI(verticalCoords, 4);

		retVal[0] = horizontalCoords[1];	// left
		retVal[1] = horizontalCoords[2];	// right

		retVal[2] = verticalCoords[1];		// top
		retVal[3] = verticalCoords[2];		// bottom

		return true;
	}

	return false;
}


#ifdef _DEBUG
void NarrowCollisionStrategy::DumpPixels(int width, int height, uint8_t * data)
{
	uint32_t * dPtr = reinterpret_cast<uint32_t*>(data);

	for (size_t count = 0; count < width * height; count++)
	{
		uint32_t t = *(dPtr);
		uint32_t alpha = (t & 0xff000000) >> 24;
		uint32_t red = (t & 0x00ff0000) >> 16;
		uint32_t green = (t & 0x0000ff00) >> 8;
		uint32_t blue = (t & 0x000000ff);

		char buf[64];
		sprintf_s(buf, "a=%x r=%x g=%x b=%x\n", alpha, red, green, blue);
		OutputDebugStringA(buf);

		dPtr++;
	}
}
#endif // _DEBUG
