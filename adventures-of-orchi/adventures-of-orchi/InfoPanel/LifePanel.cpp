#include "pch.h"
#include "LifePanel.h"
//#include "HeartData.h"
#include "Constants.h"
#include "Common\DeviceResources.h"
#include "Common\DirectXHelper.h"

using namespace DirectX;
using namespace Microsoft::WRL;
using namespace DX;

void LifePanel::Render(const shared_ptr<DeviceResources>& deviceResources)
{
	D2D1_SIZE_F size = deviceResources->GetD2DDeviceContext()->GetSize();

	float fLeft = size.width - (size.width * (RIGHT_MARGIN_RATIO - 0.01f));
	float fTop = size.height * 0.01f;
	float fRight = size.width - (size.width * 0.01f);
	float fBottom = size.height / INFO_PANEL_HEIGHT_CONSTANT;

	DrawText(fLeft, fTop, deviceResources);
	DrawBox(fLeft, fTop, fRight, fBottom, deviceResources);
}

//void LifePanel::BuildPanel(std::vector<BaseSpriteData> * m_heartData)
//{
//	float x = 0.0f;
//	float y = 0.0f;
//
//	m_heartData->clear();
//
//	float fHeartPanelColumnWidth = m_fPanelWidth / NUM_HEART_COLUMNS;
//	float fHeartPanelRowHeight = m_fPanelHeight / NUM_HEART_ROWS;
//
//	for (int row = 0; row < 2; row++)
//	{
//		for (int column = 0; column < 10; column++)
//		{
//			HeartData data(
//				0,
//				0,
//				m_fHorizontalOffset + fHeartPanelColumnWidth * static_cast<float>(column) + (fHeartPanelColumnWidth / 2.0f),
//				m_fVerticalOffset + fHeartPanelRowHeight * static_cast<float>(row) + (fHeartPanelRowHeight / 2.0f));
//
//			m_heartData->push_back(data);
//		}
//	}
//}