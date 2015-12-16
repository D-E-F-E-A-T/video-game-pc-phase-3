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

using namespace DirectX;
using namespace Microsoft::WRL;
using namespace DX;
using namespace std;
using namespace Platform;

class InfoPanel
{
public:

	void CreateText(
		String ^ text, 
		float2 fWindowSize, 
		const shared_ptr<DeviceResources>& deviceResources);

	void DrawText(
		float fLeft, 
		float fTop, 
		float fRight,
		const shared_ptr<DeviceResources>& deviceResources);

	void DrawBox(
		float fLeft, 
		float fTop, 
		float fRight, 
		float fBottom, 
		const shared_ptr<DeviceResources>& deviceResources);

	virtual void Render(const shared_ptr<DeviceResources>& deviceResources) = 0;

protected:

	ComPtr<IDWriteTextLayout1> m_textLayout;
	DWRITE_TEXT_RANGE m_textRange;

private:
};
