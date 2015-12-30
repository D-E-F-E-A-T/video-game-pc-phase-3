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
#include "LookaheadCollisionStrategy.h"

#ifdef _DEBUG
int LookaheadCollisionStrategy::Detect(
	Player * player,
	Space * collided,
	Grid * grid,
	int * intersectRect,
	float2 screenDimensions,
	XMFLOAT3 * vecDifferential,
	float * rectLookaheadZone)
#else
int LookaheadCollisionStrategy::Detect(
	Player * player,
	Space * collided,
	Grid * grid,
	int * intersectRect,
	float2 screenDimensions,
	XMFLOAT3 * vecDifferential)
#endif // _DEBUG
{
	return 0;
}