#include "pch.h"
#include "Player.h"
#include "..\Constants.h"

void Player::SkipNorth()
{
	m_fLocationRatio = float2{ m_fLocationRatio.x , 0.90f };
}

void Player::SkipEast()
{
	m_fLocationRatio = float2{ LEFT_MARGIN_RATIO + 0.05f, m_fLocationRatio.y };
}

void Player::SkipSouth()
{
	m_fLocationRatio = float2{ m_fLocationRatio.x, 0.1f };
}

void Player::SkipWest()
{
	m_fLocationRatio = float2{ 1.0f - RIGHT_MARGIN_RATIO - 0.05f, m_fLocationRatio.y };
}
