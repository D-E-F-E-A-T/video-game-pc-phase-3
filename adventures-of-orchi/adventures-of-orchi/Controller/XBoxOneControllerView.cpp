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
#include "..\Constants.h"
#include "XBoxOneControllerView.h"
#include "..\Model\Player.h"

void XBoxOneControllerView::FetchControllerInput()
{
	if (!m_isControllerConnected)
	{
		//
		// Enumerating for XInput devices takes 'time' on the order of milliseconds.
		// Any time a device is not currently known as connected (not yet called XInput, or calling
		// an XInput function after a failure) ennumeration happens.
		// An app should avoid repeatedly calling XInput functions if there are no known devices connected
		// as this can slow down application performance.
		// This sample takes the simple approach of not calling XInput functions after failure
		// until a specified timeout has passed.
		//
		uint64 currentTime = ::GetTickCount64();
		if (currentTime - m_lastEnumTime < XINPUT_ENUM_TIMEOUT_MS)
		{
			return;
		}
		m_lastEnumTime = currentTime;

		// Check for controller connection by trying to get the capabilties
		uint32 capsResult = XInputGetCapabilities(0, XINPUT_FLAG_GAMEPAD, &m_xinputCaps);
		if (capsResult != ERROR_SUCCESS)
		{
			return;
		}

		// Device is connected
		m_isControllerConnected = true;
	}

	uint32 stateResult = XInputGetState(0, &m_xinputState);
	if (stateResult != ERROR_SUCCESS)
	{
		// Device is no longer connected
		m_isControllerConnected = false;
		m_lastEnumTime = ::GetTickCount64();
	}
}

// Maybe this should just return direction and not do any actions.
bool XBoxOneControllerView::MovePlayer(
	Player * pPlayer, 
	int nCollisionState, 
	int * nDirection)
{
	bool retVal = false;

	if (m_xinputState.Gamepad.wButtons & XINPUT_GAMEPAD_DPAD_UP)
	{
		pPlayer->MoveNorth(PLAYER_MOVE_VELOCITY);
		*nDirection = NORTH;
		retVal = true;
	}
	else if (m_xinputState.Gamepad.wButtons & XINPUT_GAMEPAD_DPAD_DOWN)
	{
		pPlayer->MoveSouth(PLAYER_MOVE_VELOCITY);
		*nDirection = SOUTH;
		retVal = true;
	}
	else if (m_xinputState.Gamepad.wButtons & XINPUT_GAMEPAD_DPAD_LEFT)
	{
		pPlayer->MoveWest(PLAYER_MOVE_VELOCITY);
		*nDirection = WEST;
		retVal = true;
	}
	else if (m_xinputState.Gamepad.wButtons & XINPUT_GAMEPAD_DPAD_RIGHT)
	{
		pPlayer->MoveEast(PLAYER_MOVE_VELOCITY);
		*nDirection = EAST;
		retVal = true;
	}
	else
	{
		*nDirection = HandleLeftThumbStick(
			pPlayer, 
			nCollisionState, 
			*nDirection, 
			m_xinputState.Gamepad.sThumbLX, 
			m_xinputState.Gamepad.sThumbLY,
			&retVal);
	}

	return retVal;
}

unsigned short XBoxOneControllerView::CheckAButton()
{
	return m_xinputState.Gamepad.wButtons & XINPUT_GAMEPAD_A;
}

int XBoxOneControllerView::HandleLeftThumbStick(
	Player * pPlayer, 
	int nCollisionState, 
	int nSwordDirection, 
	short horizontal, 
	short vertical,
	bool * bStatus)
{
	float radius = (float)(sqrt((double)horizontal * (double)horizontal + (double)vertical * (double)vertical));
	float velocity = 0.f;
	int retVal = NORTH;

	if (radius < WALKING_THRESHOLD)
	{
		*bStatus = false;
		return nSwordDirection;
	}

	if (radius >= WALKING_THRESHOLD && radius < RUNNING_THRESHOLD)
		velocity = PLAYER_MOVE_VELOCITY;
	else if (radius >= RUNNING_THRESHOLD)
		velocity = PLAYER_MOVE_VELOCITY * 2.0f;

	if (horizontal == 0)
	{
		if (vertical > 0)
		{
			pPlayer->MoveNorth(velocity);
			retVal = NORTH;
		}
		else if (vertical < 0)
		{
			pPlayer->MoveSouth(velocity);
			retVal = SOUTH;
		}
	}
	else if (vertical == 0)
	{
		if (horizontal > 0)
		{
			pPlayer->MoveEast(velocity);
			retVal = EAST;
		}
		else if (horizontal < 0)
		{
			pPlayer->MoveWest(velocity);
			retVal = WEST;
		}
	}
	else
	{
		float param = (float)vertical / (float)horizontal;
		float theta = (float)(atan(param) * 180.0f / PI);

		if (horizontal > 0 && vertical > 0)
		{
			// Upper-right quadrant.
			if (theta <= 45.f)
			{
				pPlayer->MoveEast(velocity);
				retVal = EAST;
			}
			else
			{
				pPlayer->MoveNorth(velocity);
				retVal = NORTH;
			}
		}
		else if (horizontal > 0 && vertical < 0)
		{
			// Lower-right quadrant.
			if (theta >= -45.f)
			{
				pPlayer->MoveEast(velocity);
				retVal = EAST;
			}
			else
			{
				pPlayer->MoveSouth(velocity);
				retVal = SOUTH;
			}
		}
		else if (horizontal < 0 && vertical > 0)
		{
			// Upper-left quadrant.
			if (theta >= -45.f)
			{
				pPlayer->MoveWest(velocity);
				retVal = WEST;
			}
			else
			{
				pPlayer->MoveNorth(velocity);
				retVal = NORTH;
			}
		}
		else // (horizontal < 0 && vertical < 0)
		{
			// Lower-left quadrant.
			if (theta <= 45.f)
			{
				pPlayer->MoveWest(velocity);
				retVal = WEST;
			}
			else
			{
				pPlayer->MoveSouth(velocity);
				retVal = SOUTH;
			}
		}
	}

	*bStatus = true;

	return retVal;
}


void XBoxOneControllerView::OnInput(
	Character * pCharacter,
	KeyEventArgs^ args,
	float2 fHitPoint)
{

}