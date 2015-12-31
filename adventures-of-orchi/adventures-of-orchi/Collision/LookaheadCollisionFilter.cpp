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
#include "LookaheadCollisionFilter.h"

list<Space *> * LookaheadCollisionFilter::Filter(
	list<Space *> * pCollided,
	float2 fLocationRatio,
	XMFLOAT3 vecDifferential)
{
	// Calculate the Lookahead Zone.
	float fpLookaheadZone[4];

	// Determine which of the collided overlap
	//	with the lookahead zone.

	CalculateLookaheadZone(
		fLocationRatio,
		vecDifferential,
		fpLookaheadZone);

	return nullptr;
}

void LookaheadCollisionFilter::CalculateLookaheadZone(
	float2 fLocationRatio,
	XMFLOAT3 vecDifferential,
	float * fLookaheadZone)
{

}