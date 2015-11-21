#pragma once
#include "pch.h"
#include "Grid.h"
#include "Constants.h"

using namespace std;

class Utils
{
public:
	static void ConvertRatioToGridLocations(Grid grid, float2 fLocationRatio, int * column, int * row);

	static void InsertionSortI(int values[], int length);

	// To easily allow for resizing, this should return ratios.
	// The return values are relative to the entire screen.
	//	Thus, 0.f = left edge of the screen.
	//			1.f = right edge of the screen.
	static void CalculateSquareCenter(
		float screenWidth,
		float screenHeight,
		int column,
		int row,
		float * x,
		float * y);

	static void ConvertGlobalToGridLocation(float2 globalPt, float * x, float * y);
	static void InsertionSortF(float values[], int length);
	static float GetMinValue(vector<float> values, int * index);

	static float CalculateDistance(float2 pt, float2 p2);
};
