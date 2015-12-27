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

using namespace Windows::UI::Core;

class KeyboardControllerView : public ControllerView
{
public:
	void OnInput(
		Character * pCharacter,
		KeyEventArgs^ args,
		float2 fHitPoint);

	void HandleKeystroke(Player * pPlayer, int nCollisionState, KeyEventArgs^ args, float fVelocity);

protected:

private:
};
