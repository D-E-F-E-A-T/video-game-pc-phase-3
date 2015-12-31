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
#include "..\Model\Player.h"
#include "..\Model\Space.h"
#include "NarrowCollisionStrategy.h"

using namespace std;
using namespace DirectX;

class LookaheadCollisionFilter
{
public:
	list<Space *> * Filter(
		list<Space *> * pCollided,
		float2 fLocationRatio,
		XMFLOAT3 vecDifferential);	

protected:
	void CalculateLookaheadZone(
		float2 fLocationRatio,
		XMFLOAT3 vecDifferential,
		float * fLookaheadZone);

private:
	NarrowCollisionStrategy m_narrowCollisionDetectionStrategy;
};
