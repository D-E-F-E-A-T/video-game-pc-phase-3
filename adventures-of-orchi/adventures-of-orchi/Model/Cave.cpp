#include "pch.h"
#include "Cave.h"
#include "Constants.h"
#include "..\Common\DeviceResources.h"
#include "..\Common\DirectXHelper.h"
#include <DirectXColors.h>

using namespace DirectX;
using namespace DX;
using namespace D2D1;

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
	deviceResources->GetD2DDeviceContext()->Clear(ColorF(fRed, fGreen, fBlue, 1.0f));

	float fGridLeft = lpfScreenDimensions[WIDTH_INDEX] * LEFT_MARGIN_RATIO;
	float fGridRight = (1.0f - RIGHT_MARGIN_RATIO) * lpfScreenDimensions[WIDTH_INDEX];

	D2D1_RECT_F rectOuterRing
	{
		fGridLeft,
		0.0f,
		fGridRight,
		lpfScreenDimensions[HEIGHT_INDEX]
	};

	ID2D1SolidColorBrush * temp;

	ThrowIfFailed(deviceResources->GetD2DDeviceContext()->CreateSolidColorBrush(ColorF(ColorF(fRed, fGreen, fBlue, 1.0f)), &temp));

	deviceResources->GetD2DDeviceContext()->FillRectangle(
		rectOuterRing,
		temp);

	D2D1_RECT_F rectMiddleRing
	{
		fGridLeft + (1.0f * lpGrid->GetColumnWidth()),
		1.0f * lpGrid->GetRowHeight(),
		fGridRight - (1.0f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 1.0f * lpGrid->GetRowHeight()
	};

	float hue = XMVectorGetByIndex(hslColor, 0);
	float saturation = XMVectorGetByIndex(hslColor, 1);
	float value = XMVectorGetByIndex(hslColor, 2) - 0.4f;

	XMVECTOR hsvDarkColor = XMVectorSet(hue, saturation, value, 1.0f);
	XMVECTOR rgbDarkColor = XMColorHSLToRGB(hsvDarkColor);

	ThrowIfFailed(deviceResources->GetD2DDeviceContext()->CreateSolidColorBrush(ColorF(ColorF(
		XMVectorGetByIndex(rgbDarkColor, 0),
		XMVectorGetByIndex(rgbDarkColor, 1),
		XMVectorGetByIndex(rgbDarkColor, 2),
		1.0f)), &temp));

	deviceResources->GetD2DDeviceContext()->FillRectangle(
		rectMiddleRing,
		temp);




	D2D1_RECT_F rectInnerRing
	{
		fGridLeft + (3.0f * lpGrid->GetColumnWidth()),
		3.0f * lpGrid->GetRowHeight(),
		fGridRight - (3.0f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 3.0f * lpGrid->GetRowHeight()
	};

	hue = XMVectorGetByIndex(hslColor, 0);
	saturation = XMVectorGetByIndex(hslColor, 1);
	value = XMVectorGetByIndex(hslColor, 2) + 0.15f;

	hsvDarkColor = XMVectorSet(hue, saturation, value, 1.0f);
	rgbDarkColor = XMColorHSLToRGB(hsvDarkColor);

	ThrowIfFailed(deviceResources->GetD2DDeviceContext()->CreateSolidColorBrush(ColorF(ColorF(
		XMVectorGetByIndex(rgbDarkColor, 0),
		XMVectorGetByIndex(rgbDarkColor, 1),
		XMVectorGetByIndex(rgbDarkColor, 2),
		1.0f)), &temp));

	deviceResources->GetD2DDeviceContext()->FillRectangle(
		rectInnerRing,
		temp);


/*

*/

/*
	deviceResources->GetD2DDeviceContext()->DrawRectangle(
		rectMiddleRing,
		deviceResources->m_mapBrushes["white"]);

	deviceResources->GetD2DDeviceContext()->FillRectangle(
		rectInnerRing,
		deviceResources->m_mapBrushes["dodgerblue"]);
*/



/*
	deviceResources->GetD2DDeviceContext()->DrawRectangle(
		rectMiddleRing,
		deviceResources->m_mapBrushes["white"]);



	deviceResources->GetD2DDeviceContext()->DrawRectangle(
		rectInnerRing,
		deviceResources->m_mapBrushes["white"]);
*/




	D2D1_POINT_2F srcTL
	{
		fGridLeft + (1.0f * lpGrid->GetColumnWidth()),
		1.0f * lpGrid->GetRowHeight()
	};

	D2D1_POINT_2F dstTL
	{
		fGridLeft + (3.0f * lpGrid->GetColumnWidth()),
		3.0f * lpGrid->GetRowHeight()
	};

	deviceResources->GetD2DDeviceContext()->DrawLine(
		srcTL, 
		dstTL, 
		deviceResources->m_mapBrushes["black"]);

	D2D1_POINT_2F srcTR
	{
		fGridRight - (1.0f * lpGrid->GetColumnWidth()),
		1.0f * lpGrid->GetRowHeight()
	};

	D2D1_POINT_2F dstTR
	{
		fGridRight - (3.0f * lpGrid->GetColumnWidth()),
		3.0f * lpGrid->GetRowHeight()
	};

	deviceResources->GetD2DDeviceContext()->DrawLine(
		srcTR,
		dstTR,
		deviceResources->m_mapBrushes["black"]);

	D2D1_POINT_2F srcBR
	{
		fGridRight - (1.0f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 1.0f * lpGrid->GetRowHeight()
	};

	D2D1_POINT_2F dstBR
	{
		fGridRight - (3.0f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 3.0f * lpGrid->GetRowHeight()
	};

	deviceResources->GetD2DDeviceContext()->DrawLine(
		srcBR,
		dstBR,
		deviceResources->m_mapBrushes["black"]);

	D2D1_POINT_2F srcBL
	{
		fGridLeft + (1.0f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 1.0f * lpGrid->GetRowHeight()
	};

	D2D1_POINT_2F dstBL
	{
		fGridLeft + (3.0f * lpGrid->GetColumnWidth()),
		lpfScreenDimensions[HEIGHT_INDEX] - 3.0f * lpGrid->GetRowHeight()
	};

	deviceResources->GetD2DDeviceContext()->DrawLine(
		srcBL,
		dstBL,
		deviceResources->m_mapBrushes["black"]);
}