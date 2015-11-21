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
