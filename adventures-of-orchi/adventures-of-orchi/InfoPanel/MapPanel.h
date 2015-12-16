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