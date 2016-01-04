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
#include "Constants.h"
#include "..\Common\DeviceResources.h"

using namespace Microsoft::WRL;
using namespace std;

class Grid
{
public:
	Grid();
	~Grid();

	void SetWindowWidth(float fWidth);
	void SetWindowHeight(float fHeight);
	
	float GetWindowWidth()
	{
		return m_fWindowWidth;
	}

	float GetWindowHeight()
	{
		return m_fWindowHeight;
	}

	float GetGridWidth() 
	{ 
		return m_fWindowWidth * (1.0f - LEFT_MARGIN_RATIO - RIGHT_MARGIN_RATIO);
	}

	float GetGridHeight() 
	{ 
		return m_fWindowHeight * (1.0f - TOP_MARGIN_RATIO - BOTTOM_MARGIN_RATIO);
	}
	
	void SetNumColumns(int nColumns);
	void SetNumRows(int nRows);
	void SetVisibility(boolean bVisibility);

	void Draw(
		ComPtr<ID2D1DeviceContext1> context, 
		const shared_ptr<DeviceResources>& deviceResources,
		int nFramesPerSecond);

	float GetColumnWidth();
	float GetRowHeight();

	int GetNumRows() 
	{
		return m_nNumRows;
	}

	int GetNumColumns()
	{
		return m_nNumColumns;
	}

	float CalculateGridsPerFrame(
		float fVelocity,
		int nFramesPerSecond);

protected:
	void DrawMajorHorizontalLines(
		ComPtr<ID2D1DeviceContext1> context,
		ComPtr<ID2D1SolidColorBrush> brush);

	void DrawMajorVerticalLines(
		ComPtr<ID2D1DeviceContext1> context,
		ComPtr<ID2D1SolidColorBrush> brush);

	void DrawMinorHorizontalLines(
		ComPtr<ID2D1DeviceContext1> context,
		ComPtr<ID2D1SolidColorBrush> brush,
		float fFramesPerGrid);

	void DrawMinorVerticalLines(
		ComPtr<ID2D1DeviceContext1> context,
		ComPtr<ID2D1SolidColorBrush> brush,
		float fFramesPerGrid);


private:
	float m_fWindowWidth;
	float m_fWindowHeight;
	float m_fGridWidth;
	float m_fGridHeight;

	int m_nNumColumns;
	int m_nNumRows;

	boolean m_bIsVisible;
};