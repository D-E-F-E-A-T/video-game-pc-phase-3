#include "pch.h"
#include "Lot.h"

void Lot::Render(
	float lpfScreenDimensions[2],
	Grid * lpGrid,
	const shared_ptr<DeviceResources>& deviceResources)
{
	deviceResources->GetD2DDeviceContext()->Clear(D2D1::ColorF(D2D1::ColorF::Tan));
}