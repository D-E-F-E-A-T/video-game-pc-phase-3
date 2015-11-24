#include "pch.h"
#include "Cave.h"

void Cave::Render(const shared_ptr<DeviceResources>& deviceResources)
{
	deviceResources->GetD2DDeviceContext()->Clear(D2D1::ColorF(D2D1::ColorF::DarkSlateGray));
}