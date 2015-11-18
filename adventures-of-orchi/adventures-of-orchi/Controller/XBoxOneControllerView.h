#pragma once
#include "..\Model\Player.h"

class XBoxOneControllerView
{
public:
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