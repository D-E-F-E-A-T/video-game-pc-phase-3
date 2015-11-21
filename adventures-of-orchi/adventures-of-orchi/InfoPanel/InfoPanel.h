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
