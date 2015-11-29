#include "pch.h"
#include "MapPanel.h"
//#include "HeartData.h"
#include "Constants.h"
#include "Common\DeviceResources.h"
#include "Common\DirectXHelper.h"

using namespace DirectX;
using namespace Microsoft::WRL;
using namespace DX;

void MapPanel::Render(const shared_ptr<DeviceResources>& deviceResources)
{
	D2D1_SIZE_F size = deviceResources->GetD2DDeviceContext()->GetSize();

	float fLeft = size.width * 0.01f;
	float fTop = size.height * 0.01f;
	float fRight = size.width * (LEFT_MARGIN_RATIO - 0.01f);
	float fBottom = size.height / INFO_PANEL_HEIGHT_CONSTANT;
	fBottom -= (size.height * INFO_PANEL_BOTTOM_SPACING_CONSTANT);

	DrawText(fLeft, fTop, fRight, deviceResources);
	DrawBox(fLeft, fTop + (size.height * INFO_PANEL_TOP_SPACING_CONSTANT), fRight, fBottom, deviceResources);
	DrawGrid(fLeft, fTop + (size.height * INFO_PANEL_TOP_SPACING_CONSTANT), fRight, fBottom, deviceResources);
}

void MapPanel::SetDimensions(int columns, int rows)
{
	m_nDimensions[0] = columns;
	m_nDimensions[1] = rows;
}

void MapPanel::SetLocation(int column, int rows)
{
	m_nLocation[0] = column;
	m_nLocation[1] = rows;
}

void MapPanel::DrawGrid(float fLeft, float fTop, float fRight, float fBottom, const shared_ptr<DeviceResources>& deviceResources)
{
	float fColumnSpacing = (fRight - fLeft) / (float)m_nDimensions[0];
	float fRowSpacing = (fBottom - fTop) / (float)m_nDimensions[1];

#ifdef DRAW_WORLD_MAP_GRID
	for (int i = 0; i < m_nDimensions[0]; i++)
	{
		D2D1_POINT_2F src
		{
			fLeft + (fColumnSpacing * float(i)),
			fTop
		};

		D2D1_POINT_2F dst
		{
			fLeft + (fColumnSpacing * float(i)),
			fBottom
		};

		deviceResources->GetD2DDeviceContext()->DrawLine(src, dst, deviceResources->m_whiteBrush.Get());
	}

	for (int i = 0; i < m_nDimensions[1]; i++)
	{
		D2D1_POINT_2F src
		{
			fLeft,
			fTop + (fRowSpacing * float(i)),
		};

		D2D1_POINT_2F dst
		{
			fRight,
			fTop + (fRowSpacing * float(i)),
		};

		deviceResources->GetD2DDeviceContext()->DrawLine(src, dst, deviceResources->m_whiteBrush.Get());
	}
#endif // DRAW_WORLD_MAP_GRID

	float fX = fColumnSpacing * (float)m_nLocation[0] + (fColumnSpacing / 2.f);
	float fY = fRowSpacing * (float)m_nLocation[1] + (fRowSpacing / 2.f);

	fX += fLeft;
	fY += fTop;

	D2D1_ELLIPSE ellipseLocation
	{
		D2D1_POINT_2F 
		{ fX, fY },
		fRowSpacing / 5.f,
		fRowSpacing / 5.f
	};

	deviceResources->GetD2DDeviceContext()->FillEllipse(
		ellipseLocation,
		deviceResources->m_mapBrushes["green"]);
}