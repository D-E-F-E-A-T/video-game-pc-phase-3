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
#include "pch.h"
#include "..\Model\Character.h"

using namespace Windows::UI::Core;

class ControllerView
{
public:
	// Generalized to allow for AI to control Monsters.
	virtual void OnInput(
		Character * pCharacter,
		KeyEventArgs^ args,	// Keyboard, AIController
		float2 fHitPoint) = 0;	// Touch

	virtual int OnLeftThumbstick() { return 0; }
	virtual int OnLeftDirectional() { return 0; }
	virtual int OnRightThumbstick() { return 0; }
	virtual int OnRightButtons() { return 0; }

	// Posterior buttons.
	virtual bool OnLTButton() { return false; }
	virtual bool OnRTButton() { return false; }

	// Anterior buttons.
	virtual bool OnLBButton() { return false; }
	virtual bool OnRBButton() { return false; }

	virtual bool OnHomeButton() { return false; }	// Illuminated "X" button on front.
	virtual bool OnViewButton() { return false; }	// Button below-left of Home button.
	virtual bool OnMenuButton() { return false; }	// Button below-right of Home button.

	virtual bool IsConnected() { return false; }

//	void MovePlayer();
	virtual void Render() {};

protected:

private:
	
};

