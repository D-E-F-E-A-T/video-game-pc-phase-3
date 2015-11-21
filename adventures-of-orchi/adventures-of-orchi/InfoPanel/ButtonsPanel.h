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


class ButtonsPanel : public InfoPanel
{
public:
	void Render(const shared_ptr<DeviceResources>& deviceResources);

protected:

private:
};