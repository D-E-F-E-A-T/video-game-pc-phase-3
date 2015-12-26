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
#include "..\Constants.h"
#include "..\Common\DeviceResources.h"

using namespace std;

class TouchScreenControllerView
{
public:
	void RenderButtonTouchControls(
		float2 fWindowBounds,
		bool bXButtonPressed,
		bool bYButtonPressed,
		bool bAButtonPressed,
		bool bBButtonPressed,
		const shared_ptr<DeviceResources>& deviceResources);

	void RenderDirectionalTouchControls(
		float2 fWindowBounds,
		bool bNorthButtonPressed,
		bool bEastButtonPressed,
		bool bSouthButtonPressed,
		bool bWestButtonPressed,
		const std::shared_ptr<DeviceResources>& deviceResources);

	// TODO: Use function pointers:
	bool CheckNorthButton(float2 fWindowBounds, float2 fHitPoint);
	bool CheckEastButton(float2 fWindowBounds, float2 fHitPoint);
	bool CheckSouthButton(float2 fWindowBounds, float2 fHitPoint);
	bool CheckWestButton(float2 fWindowBounds, float2 fHitPoint);

	bool CheckYButton(float2 fWindowBounds, float2 fHitPoint);
	bool CheckBButton(float2 fWindowBounds, float2 fHitPoint);
	bool CheckAButton(float2 fWindowBounds, float2 fHitPoint);
	bool CheckXButton(float2 fWindowBounds, float2 fHitPoint);

protected:


private:
};
