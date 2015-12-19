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

using namespace std;

void VectorGraphic::Render(
	ComPtr<ID3D11RenderTargetView> renderTargetView,
	float2  fLocationRatio,
	float fRotationInRadians,
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
			float fCurrent[3];
			float fNext[3];

			// Convert from XMFLOAT3 to XMVECTOR to
			//	support SIMD architectures.
			XMVECTOR xmVectorCurrent = XMLoadFloat3(&(*iteratorVertices));
			
			fCurrent[0] = XMVectorGetX(xmVectorCurrent);
			fCurrent[1] = XMVectorGetY(xmVectorCurrent);
			fCurrent[2] = XMVectorGetZ(xmVectorCurrent);

			XMVECTOR xmVectorNext = XMLoadFloat3(&(*(next(iteratorVertices))));
			fNext[0] = XMVectorGetX(xmVectorNext);
			fNext[1] = XMVectorGetY(xmVectorNext);
			fNext[2] = XMVectorGetZ(xmVectorNext);

			D2D1_POINT_2F src
			{
				fCurrent[0] * 100.f,
				fCurrent[1] * 100.f
			};

			D2D1_POINT_2F dst
			{
				fNext[0] * 100.f,
				fNext[1] * 100.f
			};

			m_deviceResources->GetD2DDeviceContext()->DrawLine(
				src, 
				dst, 
				m_deviceResources->m_mapBrushes["red"]);
		}
	}




	//for (list<XMFLOAT3> line : listElements)
	//{

	//}
	//#ifdef RENDER_DIAGNOSTICS
	//		float2 fScreenLocation = fLocationRatio * fWindowDimensions;
	//
	//		D2D1_RECT_F rect
	//		{
	//			fScreenLocation.x - (fWindowDimensions.x / 100.f),
	//			fScreenLocation.y - (fWindowDimensions.y / 100.f),
	//			fScreenLocation.x + (fWindowDimensions.x / 100.f),
	//			fScreenLocation.y + (fWindowDimensions.y / 100.f)
	//		};
	//
	//		DEVICE_CONTEXT_2D->FillRectangle(
	//			rect,
	//			m_deviceResources->m_mapBrushes["red"]);
	//#endif // RENDER_DIAGNOSTICS
}

	//			m_deviceResources->m_mapBrushes["red"]);