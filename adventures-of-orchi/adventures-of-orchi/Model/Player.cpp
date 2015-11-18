#include "pch.h"
#include "Player.h"
#include "..\Constants.h"
#include "..\ScreenUtils.h"

using namespace DirectX;





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
