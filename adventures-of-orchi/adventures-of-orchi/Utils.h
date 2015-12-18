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

	static float CalculateSquareHeight(float screenHeight);
	static float CalculateSquareWidth(float screenWidth);

	static void CalculateSquareOrigin(
		float fScreenWidth,
		float fScreenHeight,
		int nColumn,
		int nRow,
		float * fXRatio,
		float * fYRatio);
};
