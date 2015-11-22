#include "pch.h"
#include "PackPanel.h"
#include "Constants.h"
#include "Common\DeviceResources.h"
#include "Common\DirectXHelper.h"

using namespace DirectX;
using namespace Microsoft::WRL;
using namespace DX;


void PackPanel::Render(const shared_ptr<DeviceResources>& deviceResources)
{
	D2D1_SIZE_F size = deviceResources->GetD2DDeviceContext()->GetSize();

	float fLeft = size.width * 0.01f;
	float fTop = (size.height / INFO_PANEL_HEIGHT_CONSTANT) * 2.0f;
	float fRight = size.width * (LEFT_MARGIN_RATIO - 0.01f);
	float fBottom = (size.height / INFO_PANEL_HEIGHT_CONSTANT) * 3.0f;
	fBottom -= (size.height * INFO_PANEL_BOTTOM_SPACING_CONSTANT);

	DrawText(fLeft, fTop, fRight, deviceResources);
	DrawBox(fLeft, fTop + (size.height * INFO_PANEL_TOP_SPACING_CONSTANT), fRight, fBottom, deviceResources);
}
