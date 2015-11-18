#include "pch.h"
#include "MapPanel.h"
//#include "HeartData.h"
#include "Constants.h"
#include "Common\DeviceResources.h"
#include "Common\DirectXHelper.h"

using namespace DirectX;
using namespace Microsoft::WRL;
using namespace DX;


void MapPanel::DrawText(const shared_ptr<DeviceResources>& deviceResources)
{
	D2D1_SIZE_F size = deviceResources->GetD2DDeviceContext()->GetSize();

	float fTop = size.height * 0.01f;
	float fLeft = 0.0f;// size.width - (size.width * LEFT_MARGIN_RATIO);

	deviceResources->GetD2DDeviceContext()->DrawTextLayout(
		D2D1::Point2F(fLeft, fTop),
		m_textLayout.Get(),
		deviceResources->m_whiteBrush.Get()
		);
}