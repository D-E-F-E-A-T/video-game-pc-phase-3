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
#include "..\Model\Player.h"
#include "ControllerView.h"

class XBoxOneControllerView : public ControllerView
{
public:
	void OnInput(
		Character * pCharacter,
		KeyEventArgs^ args,
		float2 fHitPoint);

	void FetchControllerInput();
	void MovePlayer(
		Player * pPlayer,
		int collisionState,
		int * swordDirection);

	int HandleLeftThumbStick(short horizontal, short vertical);

	bool GetIsControllerConnected() { return m_isControllerConnected; }
	unsigned short CheckAButton();

protected:

private:
	int HandleLeftThumbStick(
		Player * pPlayer,
		int nCollisionState,
		int nSwordDirection,
		short horizontal,
		short vertical);

	bool                    m_isControllerConnected;  // Do we have a controller connected
	XINPUT_CAPABILITIES     m_xinputCaps;             // Capabilites of the controller
	XINPUT_STATE            m_xinputState;            // The current state of the controller
	uint64                  m_lastEnumTime;           // Last time a new controller connection was checked
};