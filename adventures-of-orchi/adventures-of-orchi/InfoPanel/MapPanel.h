#pragma once
#include "pch.h"
#include "Constants.h"
#include "Common\DeviceResources.h"
#include "Common\DirectXHelper.h"
#include "InfoPanel.h"

using namespace DirectX;
using namespace Microsoft::WRL;
using namespace DX;
using namespace std;

class MapPanel : public InfoPanel
{
public:
	void Render(const shared_ptr<DeviceResources>& deviceResources);
	void SetDimensions(int rows, int columns);
	void SetLocation(int row, int column);

protected:
	void DrawGrid(float fLeft, float fTop, float fRight, float fBottom, const shared_ptr<DeviceResources>& deviceResources);

	int m_nDimensions[2];
	int m_nLocation[2];


private:
};