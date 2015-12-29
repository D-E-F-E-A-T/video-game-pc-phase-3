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
#include "Utils.h"
#include "Grid.h"
#include "Constants.h"

using namespace std;

void Utils::ConvertRatioToGridLocations(Grid grid, float2 fLocationRatio, int * column, int * row)
{
	float fHorizontalUnits =
		(float)TOTAL_GRID_DIVISIONS / (float)grid.GetNumColumns();

	float fVerticalUnits =
		(float)TOTAL_GRID_DIVISIONS / (float)grid.GetNumRows();

	int nHorizontalLocation =
		(int)(fLocationRatio.x * (float)TOTAL_GRID_DIVISIONS) / fHorizontalUnits;

	int nVerticalLocation =
		(int)(fLocationRatio.y * (float)TOTAL_GRID_DIVISIONS) / fVerticalUnits;

	*column = nHorizontalLocation;
	*row = nVerticalLocation;
}

void Utils::InsertionSortI(int values[], int length)
{
	int j, temp;

	for (int i = 0; i < length; i++)
	{
		j = i;

		while (j > 0 && values[j] < values[j - 1])
		{
			temp = values[j];
			values[j] = values[j - 1];
			values[j - 1] = temp;
			j--;
		}
	}
}

// To easily allow for resizing, this should return ratios.
// The return values are relative to the entire screen.
//	Thus, 0.f = left edge of the screen.
//			1.f = right edge of the screen.
/*
void Utils::CalculateSquareCenter(
	float screenWidth,
	float screenHeight,
	int column,
	int row,
	float * x,
	float * y)
{
	float rowHeight = CalculateSquareHeightRatio(screenHeight);
	float columnWidth = CalculateSquareWidthRatio(screenWidth);

	*x = (screenWidth * LEFT_MARGIN_RATIO) + MARGIN + (columnWidth * column) + (columnWidth / 2.0f);
	*y = MARGIN + (rowHeight * row) + (rowHeight / 2.0f);

	*x /= screenWidth;
	*y /= screenHeight;
}
*/
void Utils::CalculateSquareCenter(
	float screenWidth,
	float screenHeight,
	int column,
	int row,
	float * x,
	float * y)
{
	float gridWidth = screenWidth -
		(screenWidth * LEFT_MARGIN_RATIO) -
		(screenWidth * RIGHT_MARGIN_RATIO);

	float rowHeight = (screenHeight - 2.0f * MARGIN) / NUM_GRID_ROWS;
	float columnWidth = (gridWidth - 2.0f * MARGIN) / NUM_GRID_COLUMNS;

	*x = (screenWidth * LEFT_MARGIN_RATIO) + MARGIN + (columnWidth * column) + (columnWidth / 2.0f);
	*y = MARGIN + (rowHeight * row) + (rowHeight / 2.0f);

	*x /= screenWidth;
	*y /= screenHeight;
}

/*
void Utils::CalculateSquareOrigin(
	float fScreenWidth,
	float fScreenHeight,
	int nColumn,
	int nRow,
	float * fXRatio,
	float * fYRatio)
{
	float rowHeight = CalculateSquareHeight(fScreenHeight);
	float columnWidth = CalculateSquareWidth(fScreenWidth);

	*fXRatio = ((fScreenWidth * LEFT_MARGIN_RATIO) + MARGIN + (columnWidth * (float)nColumn)) / fScreenWidth;
	*fYRatio = (MARGIN + (rowHeight * (float)nRow)) / fScreenHeight;
}
*/

float Utils::CalculateSquareHeightRatio(float fScreenHeight)
{
	float fSquareRawHeight = fScreenHeight / (float)NUM_GRID_ROWS;

	return fSquareRawHeight / fScreenHeight;
}

float Utils::CalculateSquareWidthRatio(float fScreenWidth)
{
	float gridWidth = fScreenWidth -
		(fScreenWidth * LEFT_MARGIN_RATIO) -
		(fScreenWidth * RIGHT_MARGIN_RATIO);

	float fSquareRawWidth = gridWidth / (float)NUM_GRID_COLUMNS;

	return fSquareRawWidth / fScreenWidth;
}

void Utils::ConvertGlobalToGridLocation(
	float2 globalPt,
	float * x,
	float * y)
{
	// globalPt.x is relative then entire width of the screen.
	//	Need to subtract the left margin before converting to 
	//	the correct Grid location.
	*x = (globalPt.x - LEFT_MARGIN_RATIO) / (1.0f - LEFT_MARGIN_RATIO - RIGHT_MARGIN_RATIO);
	*y = globalPt.y;
}

void Utils::InsertionSortF(float values[], int length)
{
	int j, temp;

	for (int i = 0; i < length; i++)
	{
		j = i;

		while (j > 0 && values[j] < values[j - 1])
		{
			temp = values[j];
			values[j] = values[j - 1];
			values[j - 1] = temp;
			j--;
		}
	}
}

float Utils::GetMinValue(vector<float> values, int * index)
{
	float retVal = 99999999.f;

	vector<float>::const_iterator iterator;
	int counter = 0;

	for (iterator = values.begin(); iterator != values.end(); iterator++)
	{
		if ((*iterator) < retVal)
		{
			retVal = *iterator;
			*index = counter;
		}

		counter++;
	}

	return retVal;
}

float Utils::CalculateDistance(
	float2 p1, float2 p2)
{
	float deltaX = fabs(p1.x - p2.x);
	float deltaY = fabs(p1.y - p2.y);

	return sqrt((deltaX * deltaX) + (deltaY * deltaY));
}

boolean Utils::IsPointInPolygon(D2D1_POINT_2F pt, vector<D2D1_POINT_2F> * polygon)
{
	return
		((pt.x > polygon->at(UPPER_LEFT).x) && (pt.y > polygon->at(UPPER_LEFT).y)) &&
		((pt.x < polygon->at(UPPER_RIGHT).x) && (pt.y > polygon->at(UPPER_RIGHT).y)) &&
		((pt.x < polygon->at(LOWER_RIGHT).x) && (pt.y < polygon->at(LOWER_RIGHT).y)) &&
		((pt.x > polygon->at(LOWER_LEFT).x) && (pt.y < polygon->at(LOWER_LEFT).y));
}
