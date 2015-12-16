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
#include "pch.h"
#include "Player.h"
#include "..\Constants.h"

void Player::SkipNorth()
{
	m_fLocationRatio = float2{ m_fLocationRatio.x , 0.85f };
}

void Player::SkipEast()
{
	m_fLocationRatio = float2{ LEFT_MARGIN_RATIO + 0.1f, m_fLocationRatio.y };
}

void Player::SkipSouth()
{
	m_fLocationRatio = float2{ m_fLocationRatio.x, 0.15f };
}

void Player::SkipWest()
{
	m_fLocationRatio = float2{ 1.0f - RIGHT_MARGIN_RATIO - 0.1f, m_fLocationRatio.y };
}
