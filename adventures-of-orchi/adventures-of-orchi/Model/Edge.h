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
#include "VectorGraphic.h"
#include "Portal.h"
#include "Constants.h"
#include "..\Wireframe\EdgeFrame.h"


class Edge : public Portal
{
public:
	Edge(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensionRatio,
		int nDirection,
		int nDestination,
		const shared_ptr<DeviceResources>& deviceResources) :
		Portal(
			pfLocationRatio,
			fRotationInRadians,
			pfDimensionRatio,
			nDestination,
#ifdef RENDER_DIAGNOSTICS
			true,
#elif // RENDER_DIAGNOSTICS
			false,
#endif // RENDER_DIAGNOSTICS
			deviceResources)
	{
		m_nDirection = nDirection;

		// TODO: Consider using Flyweight.
		m_pRenderable = new VectorGraphic(
			deviceResources,
			new EdgeFrame());
	}

	int GetDirection() { return m_nDirection; }

	virtual bool IsOverlapping(Space * pOther);
	//Action * Act(World *);


protected:

private:
	int m_nDirection;
};