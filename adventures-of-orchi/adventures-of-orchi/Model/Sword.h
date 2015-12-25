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
			nullptr,
			deviceResources)
	{
		m_pRenderable = new Texture("sword.dds", deviceResources);
	}

	void Inertia(float fVelocity)
	{		
		Movable::Inertia(fVelocity);

		if (m_fLocationRatio.x > 1.0f - RIGHT_MARGIN_RATIO - 0.005f ||
			m_fLocationRatio.x < LEFT_MARGIN_RATIO + 0.005f ||
			m_fLocationRatio.y > 1.0f - 0.005f ||
			m_fLocationRatio.y < 0.0f + 0.005f)
		{
			// Will need to change this logic when 
			//	checking for collisions.
			m_bIsVisible = false;
			m_bIsFlying = false;
		}
	}

	void Aim(int nDirection) 
	{ 
		m_nDirection = nDirection;
		m_bIsFlying = true; 
	}

	bool IsFlying() { return m_bIsFlying; }

protected:
	bool m_bIsFlying;

private:
};