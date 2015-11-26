#include "pch.h"
#include "Cave.h"
#include "Constants.h"
#include <DirectXColors.h>

using namespace DirectX;

void Cave::Render(
	float lpfScreenDimensions[2],
	Grid * lpGrid,
	const shared_ptr<DeviceResources>& deviceResources)
{
	float fRed = (float)m_nRed / 255.0f;
	float fGreen = (float)m_nGreen / 255.0f;
	float fBlue = (float)m_nBlue / 255.0f;

	XMVECTOR rbgColor = XMVectorSet(
		fRed,
		fGreen,
		fBlue,
		1.0f);

	XMVECTOR hslColor = XMColorRGBToHSL(rbgColor);
	deviceResources->GetD2DDeviceContext()->Clear(D2D1::ColorF(fRed, fGreen, fBlue, 1.0f));

	float fGridLeft = lpfScreenDimensions[WIDTH_INDEX] * LEFT_MARGIN_RATIO;
	float fGridRight = (1.0f - RIGHT_MARGIN_RATIO) * lpfScreenDimensions[WIDTH_INDEX];

	D2D1_RECT_F rectOuterRing
	{
		fGridLeft,
		0.0f,
		fGridRight,
		lpfScreenDimensions[HEIGHT_INDEX]
	};

	D2D1_RECT_F rectMiddleRing
	{
		fGridLeft + (1.0f * lpGrid->GetColumnWidth()),
		1.0f * lpGrid->GetRowHeight(),
		fGridRight - (1.0f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 1.0f * lpGrid->GetRowHeight()
	};

	D2D1_RECT_F rectInnerRing
	{
		fGridLeft + (3.0f * lpGrid->GetColumnWidth()),
		3.0f * lpGrid->GetRowHeight(),
		fGridRight - (3.0f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 3.0f * lpGrid->GetRowHeight()
	};

	deviceResources->GetD2DDeviceContext()->FillRectangle(
		rectOuterRing,
		deviceResources->m_redBrush.Get());

	deviceResources->GetD2DDeviceContext()->FillRectangle(
		rectInnerRing,
		deviceResources->m_blueBrush.Get());



	deviceResources->GetD2DDeviceContext()->DrawRectangle(
		rectMiddleRing,
		deviceResources->m_whiteBrush.Get());



	deviceResources->GetD2DDeviceContext()->DrawRectangle(
		rectInnerRing,
		deviceResources->m_whiteBrush.Get());




	D2D1_POINT_2F srcTL
	{
		fGridLeft + (1.5f * lpGrid->GetColumnWidth()),
		1.5f * lpGrid->GetRowHeight()
	};

	D2D1_POINT_2F dstTL
	{
		fGridLeft + (2.0f * lpGrid->GetColumnWidth()),
		2.0f * lpGrid->GetRowHeight()
	};

	deviceResources->GetD2DDeviceContext()->DrawLine(
		srcTL, 
		dstTL, 
		deviceResources->m_whiteBrush.Get());

	D2D1_POINT_2F srcTR
	{
		fGridRight - (1.5f * lpGrid->GetColumnWidth()),
		1.5f * lpGrid->GetRowHeight()
	};

	D2D1_POINT_2F dstTR
	{
		fGridRight - (2.0f * lpGrid->GetColumnWidth()),
		2.0f * lpGrid->GetRowHeight()
	};

	deviceResources->GetD2DDeviceContext()->DrawLine(
		srcTR,
		dstTR,
		deviceResources->m_whiteBrush.Get());

	D2D1_POINT_2F srcBR
	{
		fGridRight - (1.5f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 1.5f * lpGrid->GetRowHeight()
	};

	D2D1_POINT_2F dstBR
	{
		fGridRight - (2.0f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 2.0f * lpGrid->GetRowHeight()
	};

	deviceResources->GetD2DDeviceContext()->DrawLine(
		srcBR,
		dstBR,
		deviceResources->m_whiteBrush.Get());

	D2D1_POINT_2F srcBL
	{
		fGridLeft + (1.5f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 1.5f * lpGrid->GetRowHeight()
	};

	D2D1_POINT_2F dstBL
	{
		fGridLeft + (2.0f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 2.0f * lpGrid->GetRowHeight()
	};

	deviceResources->GetD2DDeviceContext()->DrawLine(
		srcBL,
		dstBL,
		deviceResources->m_whiteBrush.Get());
}