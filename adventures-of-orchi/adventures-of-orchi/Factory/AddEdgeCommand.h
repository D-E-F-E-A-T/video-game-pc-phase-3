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

		float2 fOriginRatio;	// Top-Left
		float2 fDimensionRatio; // { 0.01f, 0.01f };

		float2 fSquareRatio =
		{
			Utils::CalculateSquareHeightRatio(fScreenDimensions.x),
			Utils::CalculateSquareWidthRatio(fScreenDimensions.y)
		};

		switch (((ServiceProxy::AddEdgeCommand ^)command)->Direction)
		{
		case NORTH:
			fDimensionRatio = float2 
			{
				fSquareRatio.x,
				0.01f
			};

			fOriginRatio = float2
			{
				fX - fSquareRatio.x / 2.0f,
				fY - fSquareRatio.y / 2.0f
			};

			break;

		case EAST:
			fDimensionRatio = float2
			{
				0.01f,
				fSquareRatio.y
			};

			fOriginRatio = float2
			{
				fX + (fSquareRatio.x / 2.0f) - fDimensionRatio.x,
				fY - (fSquareRatio.y / 2.0f)
			};
			break;

		case SOUTH:
			fDimensionRatio = float2
			{
				fSquareRatio.x,
				0.1f
			};

			fOriginRatio = float2
			{
				fX - (fSquareRatio.x / 2.0f),
				fY + (fSquareRatio.y / 2.0f) - fDimensionRatio.y
			};

			break;

		case WEST:
			fDimensionRatio = float2
			{
				0.1f,
				fSquareRatio.y
			};

			fOriginRatio = float2
			{
				fX - (fSquareRatio.x / 2.0f),
				fY - (fSquareRatio.y / 2.0f)
			};

			break;
		}



		(*pSubdivision)->Set(LAYER_2D,
			new Edge(
				fOriginRatio,
				0.f,					// Rotation.
				fDimensionRatio, 
				((ServiceProxy::AddEdgeCommand ^)command)->Direction,
				((ServiceProxy::AddEdgeCommand ^)command)->Destination,
				deviceResources));
	}

protected:

private:
};
