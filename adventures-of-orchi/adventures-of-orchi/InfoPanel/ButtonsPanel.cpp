#include "pch.h"
#include "ButtonsPanel.h"
#include "Constants.h"
#include "Common\DeviceResources.h"
#include "Common\DirectXHelper.h"

using namespace DirectX;
using namespace Microsoft::WRL;
using namespace DX;


void ButtonsPanel::Render(const shared_ptr<DeviceResources>& deviceResources)
{
	D2D1_SIZE_F size = deviceResources->GetD2DDeviceContext()->GetSize();

	float fLeft = size.width - (size.width * (RIGHT_MARGIN_RATIO - 0.01f));
	float fTop = size.height / INFO_PANEL_HEIGHT_CONSTANT;
	float fRight = size.width - (size.width * 0.01f);
	float fBottom = (size.height / INFO_PANEL_HEIGHT_CONSTANT) * 2.0f;

	DrawText(fLeft, fTop, deviceResources);
	DrawBox(fLeft, fTop, fRight, fBottom, deviceResources);
}