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
#include "BuildCommand.h"
#include "..\Model\Edge.h"
#include "..\Utils.h"
#include "..\Model\World.h"

class AddEdgeCommand : public BuildCommand
{
public:
	void Process(
		World ** pWorld,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pSubdivision,
		const shared_ptr<DeviceResources>& deviceResources)
	{
		float fX;
		float fY;
		
		Utils::CalculateSquareCenter(
			fScreenDimensions.x,
			fScreenDimensions.y,
			((ServiceProxy::AddEdgeCommand ^)command)->X,
			((ServiceProxy::AddEdgeCommand ^)command)->Y,
			&fX,
			&fY);

		float2 fOriginRatio;	// Top-Left, relative to ENTIRE screen.
		float2 fDimensionRatio;	// Area to squeeze the wireframe into, relative to a single grid square.

		float2 fSquareRatio =
		{
			Utils::CalculateSquareWidthRatio(fScreenDimensions.x),
			Utils::CalculateSquareHeightRatio(fScreenDimensions.y)
		};

		switch (((ServiceProxy::AddEdgeCommand ^)command)->Direction)
		{
			case NORTH:
			{
				fDimensionRatio = float2
				{
					fSquareRatio.x,
					fSquareRatio.y * EDGE_RATIO
				};

				// The is the height ratio of the edge. It still needs to be
				//	offset since the location ratio is based on the 
				//	centroid, now.
				float fEdgeHeight =
					(fScreenDimensions.y / (float)NUM_GRID_ROWS) * EDGE_RATIO;

				float fEdgeHeightMidpoint =
					fEdgeHeight / 2.0f;

				float fEdgeHeightMidpointOffsetRatio =
					fEdgeHeightMidpoint / fScreenDimensions.y;

				fOriginRatio = float2
				{
					fX,
					(fY - fSquareRatio.y / 2.0f) + fEdgeHeightMidpointOffsetRatio
				};
			}
			break;

			case EAST:
			{
				fDimensionRatio = float2
				{
					fSquareRatio.x * EDGE_RATIO,
					fSquareRatio.y
				};

				float fEdgeWidth =
					((fScreenDimensions.x * (1.0f - LEFT_MARGIN_RATIO - RIGHT_MARGIN_RATIO))
						/ (float)NUM_GRID_COLUMNS) * EDGE_RATIO;

				float fEdgeWidthMidpoint =
					fEdgeWidth / 2.0f;

				float fEdgeWidthMidpointOffsetRatio =
					fEdgeWidthMidpoint / fScreenDimensions.x;

				fOriginRatio = float2
				{
					(fX + fSquareRatio.x / 2.0f) - fEdgeWidthMidpointOffsetRatio,
					fY
				};
			}
			break;

			case SOUTH:
			{
				fDimensionRatio = float2
				{
					fSquareRatio.x,
					fSquareRatio.y * EDGE_RATIO
				};

				float fEdgeHeight =
					(fScreenDimensions.y / (float)NUM_GRID_ROWS) * EDGE_RATIO;

				float fEdgeHeightMidpoint =
					fEdgeHeight / 2.0f;

				float fEdgeHeightMidpointOffsetRatio =
					fEdgeHeightMidpoint / fScreenDimensions.y;

				fOriginRatio = float2
				{
					fX,
					(fY + fSquareRatio.y / 2.0f) - fEdgeHeightMidpointOffsetRatio
				};
			}
			break;

			case WEST:
			{
				fDimensionRatio = float2
				{
					fSquareRatio.x * EDGE_RATIO,
					fSquareRatio.y
				};

				float fEdgeWidth =
					((fScreenDimensions.x * (1.0f - LEFT_MARGIN_RATIO - RIGHT_MARGIN_RATIO))
						/ (float)NUM_GRID_COLUMNS) * EDGE_RATIO;

				float fEdgeWidthMidpoint =
					fEdgeWidth / 2.0f;

				float fEdgeWidthMidpointOffsetRatio =
					fEdgeWidthMidpoint / fScreenDimensions.x;

				fOriginRatio = float2
				{
					(fX - fSquareRatio.x / 2.0f) + fEdgeWidthMidpointOffsetRatio,
					fY
				};
			}
			break;

			default:
			{
				fDimensionRatio = float2
				{
					fSquareRatio.x,
					fSquareRatio.y
				};

				fOriginRatio = float2
				{
					fX,
					fY
				};
			}
			break;
		}
		


		(*pSubdivision)->Set(LAYER_2D,
			new Edge(
				fOriginRatio,			// Relative to the entire screen. Not just the Grid.
				0.f,					// Rotation.
				fDimensionRatio, 
				((ServiceProxy::AddEdgeCommand ^)command)->Direction,
				((ServiceProxy::AddEdgeCommand ^)command)->Destination,
				command,
				deviceResources));
	}

protected:

private:
};
