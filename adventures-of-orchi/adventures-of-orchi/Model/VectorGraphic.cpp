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
#include "VectorGraphic.h"
#include "..\Utils.h"

using namespace std;

void VectorGraphic::Render(
	ComPtr<ID3D11RenderTargetView> renderTargetView,
	float2 fLocationRatio,
	float fRotationInRadians,
	float2 fDimensionsRatio,
	float2 fWindowDimensions,
	float2 fScaleDimensions,
	float dpi)
{
#ifdef RENDER_DIAGNOSTICS
	// Edge(Space) has a Renderable(VectorGraphic)
	// Space calls this and passes in the window dimensions.
	
	// Now, just need to transform the wireframe based on
	//	the current window dimensions.
	list<list<XMFLOAT3> *> * listElements = m_pWireframe->GetElements();

	list<list<XMFLOAT3> *>::const_iterator iteratorElements;

	for (iteratorElements = listElements->begin();
		iteratorElements != listElements->end();
		iteratorElements++)
	{
		list<XMFLOAT3>::const_iterator iteratorVertices;

		list<XMFLOAT3> * listVertices = (*iteratorElements);

		for (iteratorVertices = listVertices->begin();
			iteratorVertices != prev(listVertices->end());
			iteratorVertices++)
		{
			// Convert from XMFLOAT3 to XMVECTOR to
			//	support SIMD architectures (Luna, 2012).
			XMVECTOR vecWireframeCurrent = XMLoadFloat3(&(*iteratorVertices));
			XMVECTOR vecWireframeNext = XMLoadFloat3(&(*(next(iteratorVertices))));

			// Convention: Origin is always the centroid.
			XMVECTOR vecOriginRatio = XMVectorSet(
				fLocationRatio.x - (fDimensionsRatio.x / 2.0f),
				fLocationRatio.y - (fDimensionsRatio.y / 2.0f),
				0.0f,
				0.0f);

			// Since the originVector is now the centroid
			//	of the VectorGraphic, need to bisect 
			//	the graphic in the x and y directions.
			XMVECTOR vecDimensionsRatio = XMVectorSet(
				fDimensionsRatio.x,
				fDimensionsRatio.y,
				0.0f,
				0.0f);

			XMVECTOR vecScreenDimensions = XMVectorSet(
				fWindowDimensions.x,
				fWindowDimensions.y,
				0.0f,
				0.0f);

			
			// Calculate the resultant to place the origin
			//	in the correct spot on the grid.
			XMVECTOR vecCurrentScaled =
				(vecWireframeCurrent * vecDimensionsRatio + vecOriginRatio) * vecScreenDimensions;

			XMVECTOR vecNextScaled =
				(vecWireframeNext * vecDimensionsRatio + vecOriginRatio) * vecScreenDimensions;

			D2D1_POINT_2F src
			{
				XMVectorGetX(vecCurrentScaled), 
				XMVectorGetY(vecCurrentScaled) 
			};

			D2D1_POINT_2F dst
			{
				XMVectorGetX(vecNextScaled), 
				XMVectorGetY(vecNextScaled)
			};

			m_deviceResources->GetD2DDeviceContext()->DrawLine(
				src, 
				dst, 
				m_deviceResources->m_mapBrushes["red"]);
		}
	}

#endif // RENDER_DIAGNOSTICS
}