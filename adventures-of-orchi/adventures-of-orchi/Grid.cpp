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
	ComPtr<ID2D1SolidColorBrush> brush)
{
	if (m_bIsVisible)
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

			context->DrawLine(src, dst, brush.Get());
		}

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

			context->DrawLine(src, dst, brush.Get());
		}
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
