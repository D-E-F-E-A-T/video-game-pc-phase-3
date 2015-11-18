#pragma once
#include "Tool.h"
#include "Texture.h"

class Sword : public Tool
{
public:
	Sword(
		float2 pfLocationRatio,
		float fRotationInRadians,
		const shared_ptr<DeviceResources>& deviceResources) :
		Tool(
			pfLocationRatio,
			fRotationInRadians,
			float2{ 2.5f, 1.f },
			false,
			deviceResources)
	{
		m_pRenderable = new Texture("sword-left.dds", deviceResources);
	}

	float2 GetLocationRatio()
	{
		m_fLocationRatio = m_fLocationRatio - float2{ 0.005f, 0.f };

		if (m_fLocationRatio.x > 1.f ||
			m_fLocationRatio.x < 0.f ||
			m_fLocationRatio.y > 1.f ||
			m_fLocationRatio.y < 0.f)
		{
			m_bIsVisible = false;
		}

		return m_fLocationRatio;
	}

	void SetDirection(int nDirection) { m_nDirection = nDirection; }

protected:

private:
};