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
			//	support SIMD architectures.
			XMVECTOR vecWireframeCurrent = XMLoadFloat3(&(*iteratorVertices));
			XMVECTOR vecWireframeNext = XMLoadFloat3(&(*(next(iteratorVertices))));

			// Translate each vertex of the wireframe from 
			//	[0.0f, 1.0f] to the range of the dimensions or a 
			//	grid square.
			
			//float fWireframeXScaled = fLocationRatio.x * fDimensionsRatio.x * fWindowDimensions.x;
			//float fWireframeYScaled = fLocationRatio.y * fDimensionsRatio.y * fWindowDimensions.y;

			// Translate each vertex.
			//XMVECTOR xmOrigin = XMVectorSet(
			//	fX,
			//	fY,
			//	0.0f,
			//	0.0f);
			XMVECTOR vecOriginRatio = XMVectorSet(
				fLocationRatio.x,
				fLocationRatio.y,
				0.0f,
				0.0f);

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




	//#ifdef RENDER_DIAGNOSTICS
			//float2 fScreenLocation = fLocationRatio * fWindowDimensions;
	
			//D2D1_RECT_F rect
			//{
			//	fScreenLocation.x - (fWindowDimensions.x / 100.f),
			//	fScreenLocation.y - (fWindowDimensions.y / 100.f),
			//	fScreenLocation.x + (fWindowDimensions.x / 100.f),
			//	fScreenLocation.y + (fWindowDimensions.y / 100.f)
			//};
	
			//DEVICE_CONTEXT_2D->FillRectangle(
			//	rect,
			//	m_deviceResources->m_mapBrushes["red"]);
	//#endif // RENDER_DIAGNOSTICS
}