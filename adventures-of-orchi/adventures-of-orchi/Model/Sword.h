#pragma once
#include "Tool.h"
#include "Texture.h"
#include "..\Utils.h"

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
		m_pRenderable = new Texture("sword.dds", deviceResources);
	}

	void Inertia(float fVelocity)
	{		
		Movable::Inertia(fVelocity);

		if (m_fLocationRatio.x > 1.0f - RIGHT_MARGIN_RATIO - 0.005f ||
			m_fLocationRatio.x < LEFT_MARGIN_RATIO + 0.005f ||
			m_fLocationRatio.y > 1.f - 0.005f ||
			m_fLocationRatio.y < 0.f + 0.005f)
		{
			// Will need to change this logic when 
			//	checking for collisions.
			m_bIsVisible = false;
			m_bIsFlying = false;
		}
	}

	void SetDirection(int nDirection) { m_nDirection = nDirection; }

	void Throw() { m_bIsFlying = true; }
	bool IsFlying() { return m_bIsFlying; }

protected:
	bool m_bIsFlying;

private:
};