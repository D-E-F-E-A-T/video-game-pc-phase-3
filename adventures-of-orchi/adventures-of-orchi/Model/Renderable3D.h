#pragma once
#include "Renderable.h"
#include "..\Common\DeviceResources.h"

class Renderable3D : public Renderable
{
public:
	Renderable3D(const shared_ptr<DeviceResources>& deviceResources)
		: Renderable(deviceResources)
	{
	}

	Renderable3D()
	{
		m_pfBounds = new float[3];
	}

protected:

private:
};
