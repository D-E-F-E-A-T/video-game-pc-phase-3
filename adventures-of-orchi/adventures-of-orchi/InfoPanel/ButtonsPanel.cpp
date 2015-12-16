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
	fBottom -= (size.height * INFO_PANEL_BOTTOM_SPACING_CONSTANT);

	DrawText(fLeft, fTop, fRight, deviceResources);
	DrawBox(fLeft, fTop + (size.height * INFO_PANEL_TOP_SPACING_CONSTANT), fRight, fBottom, deviceResources);
}