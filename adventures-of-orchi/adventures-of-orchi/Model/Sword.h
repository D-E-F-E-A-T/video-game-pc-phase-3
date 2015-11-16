#pragma once
#include "Tool.h"
#include "Texture.h"

class Sword : public Tool
{
public:
	Sword(
		float2 pfLocationRatio,
		const shared_ptr<DeviceResources>& deviceResources) :
		Tool(
			pfLocationRatio,
			float2{ 1.f, 1.f },
			true,
			deviceResources)
	{
		m_pRenderable = new Texture("sword-left.dds", deviceResources);
	}

	float2 GetLocationRatio()
	{
		m_fLocationRatio = m_fLocationRatio - float2{ 0.03f, 0.f };
		return m_fLocationRatio;
	}

protected:

private:
};