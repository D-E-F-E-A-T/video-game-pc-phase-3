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
#include "Grid.h"
#include "Constants.h"

Grid::Grid()
{

}

Grid::~Grid()
{

}

void Grid::SetWindowWidth(float fWindowWidth)
{
	this->m_fWindowWidth = fWindowWidth;

	m_fGridWidth = m_fWindowWidth -
		(m_fWindowWidth * LEFT_MARGIN_RATIO) -
		(m_fWindowWidth * RIGHT_MARGIN_RATIO);
}

void Grid::SetWindowHeight(float fWindowHeight)
{
	this->m_fWindowHeight = fWindowHeight;

	m_fGridHeight = fWindowHeight;
}

void Grid::Draw(
	ComPtr<ID2D1DeviceContext1> context,
	const shared_ptr<DeviceResources>& deviceResources,
	int nFramesPerSecond)
{
	if (m_bIsVisible)
	{
		DrawMajorHorizontalLines(
			context, 
			deviceResources->m_mapBrushes["black"]);

		DrawMajorVerticalLines(
			context, 
			deviceResources->m_mapBrushes["black"]);

		float fFramesPerGrid =
			(float)nFramesPerSecond * 
			WALKING_SECONDS_PER_GRID;

		DrawMinorHorizontalLines(
			context, 
			deviceResources->m_mapBrushes["red"],
			fFramesPerGrid);

		DrawMinorVerticalLines(
			context, 
			deviceResources->m_mapBrushes["red"],
			fFramesPerGrid);
	}
}

float Grid::GetColumnWidth()
{
	return (m_fGridWidth - 2.0f * MARGIN) / NUM_GRID_COLUMNS;
}

float Grid::GetRowHeight()
{
	return (m_fWindowHeight - 2.0f * MARGIN) / NUM_GRID_ROWS;
}

void Grid::SetNumColumns(int nNumColumns)
{
	this->m_nNumColumns = nNumColumns;
}

void Grid::SetNumRows(int nNumRows)
{
	this->m_nNumRows = nNumRows;
}

void Grid::SetVisibility(boolean bVisibility)
{
	this->m_bIsVisible = bVisibility;
}

void Grid::DrawMajorHorizontalLines(
	ComPtr<ID2D1DeviceContext1> context,
	ComPtr<ID2D1SolidColorBrush> brush)
{
	// Draw the horizontal lines.
	for (int row = 0; row <= NUM_GRID_ROWS; row++)
	{
		D2D1_POINT_2F src
		{
			(m_fWindowWidth * LEFT_MARGIN_RATIO) + MARGIN,
			MARGIN + (GetRowHeight() * (float)row)
		};

		D2D1_POINT_2F dst
		{
			m_fWindowWidth - (m_fWindowWidth * RIGHT_MARGIN_RATIO) - MARGIN,
			MARGIN + (GetRowHeight() * (float)row)
		};

		context->DrawLine(src, dst, brush.Get(), 0.2f);
	}
}

void Grid::DrawMajorVerticalLines(
	ComPtr<ID2D1DeviceContext1> context,
	ComPtr<ID2D1SolidColorBrush> brush)
{
	// Draw the vertical lines.
	for (int column = 0; column <= NUM_GRID_COLUMNS; column++)
	{
		D2D1_POINT_2F src
		{
			(m_fWindowWidth * LEFT_MARGIN_RATIO) + MARGIN + (GetColumnWidth() * (float)column),
			MARGIN
		};

		D2D1_POINT_2F dst
		{
			(m_fWindowWidth * LEFT_MARGIN_RATIO) + MARGIN + (GetColumnWidth() * (float)column),
			m_fWindowHeight - MARGIN,
		};

		context->DrawLine(src, dst, brush.Get(), 0.2f);
	}


}

// Ticks along the y-axis.
void Grid::DrawMinorHorizontalLines(
	ComPtr<ID2D1DeviceContext1> context,
	ComPtr<ID2D1SolidColorBrush> brush,
	float fFramesPerGrid)
{
	float fPixelsPerFrame =
		m_fGridHeight / fFramesPerGrid;

	for (int i = 0; i < (int)fFramesPerGrid; i++)
	{
		D2D1_POINT_2F src
		{
			m_fWindowWidth / 2.0f - (m_fGridWidth * 0.005f),
			fPixelsPerFrame * (float)i
		};

		D2D1_POINT_2F dst
		{
			m_fWindowWidth / 2.0f + (m_fGridWidth * 0.005f),
			fPixelsPerFrame * (float)i
		};

		context->DrawLine(src, dst, brush.Get(), 0.75f);
	}

	// Draw horizontal has marks for pixels/frame.
	D2D1_POINT_2F srcVMiddle
	{
		m_fWindowWidth / 2.0f,
		m_fWindowHeight * TOP_MARGIN_RATIO
	};

	D2D1_POINT_2F dstVMiddle
	{
		m_fWindowWidth / 2.0f,
		m_fWindowHeight * (1.0f - BOTTOM_MARGIN_RATIO)
	};

	context->DrawLine(srcVMiddle, dstVMiddle, brush.Get(), 0.75f);
}

// Ticks along the x-axis.
void Grid::DrawMinorVerticalLines(
	ComPtr<ID2D1DeviceContext1> context,
	ComPtr<ID2D1SolidColorBrush> brush,
	float fFramesPerGrid)
{
	float fPixelsPerFrame =
		m_fGridWidth / fFramesPerGrid;

	for (int i = 0; i < (int)fFramesPerGrid; i++)
	{
		D2D1_POINT_2F src
		{
			(m_fWindowWidth * LEFT_MARGIN_RATIO) + (fPixelsPerFrame * (float)i),
			m_fWindowHeight / 2.0f - m_fWindowHeight * 0.005f
		};

		D2D1_POINT_2F dst
		{
			(m_fWindowWidth * LEFT_MARGIN_RATIO) + (fPixelsPerFrame * (float)i),
			m_fWindowHeight / 2.0f + m_fWindowHeight * 0.005f
		};

		context->DrawLine(src, dst, brush.Get(), 0.75f);
	}

	// Draw horizontal has marks for pixels/frame.
	D2D1_POINT_2F srcHMiddle
	{
		m_fWindowWidth * LEFT_MARGIN_RATIO,
		m_fWindowHeight / 2.0f
	};

	D2D1_POINT_2F dstHMiddle
	{
		m_fWindowWidth - (m_fWindowWidth * RIGHT_MARGIN_RATIO),
		m_fWindowHeight / 2.0f
	};

	context->DrawLine(srcHMiddle, dstHMiddle, brush.Get(), 0.75f);
}


float Grid::CalculateGridsPerFrame(
	float fVelocity,
	int nFramesPerSecond)
{
	// Calculate the frames/grid at the current FPS.
	//	Ex: 60 FPS * 5 (seconds per grid) = 300 frames per grid.
	float fFramesPerGrid = (float)nFramesPerSecond * fVelocity;

	// Length of each ratio division.
	// Ex: 1.0f / 300 (frames per grid) = 0.00333 grid / frame.
	//	Or ("Move 0.003333 grid for every frame")
	return 1.0f / fFramesPerGrid;
}