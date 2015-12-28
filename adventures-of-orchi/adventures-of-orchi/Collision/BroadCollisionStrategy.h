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
#include "Model\Movable.h"
#include "Model\Space.h"
#include "Model\Stack.h"

class BroadCollisionStrategy
{
public:
	BroadCollisionStrategy();

	void Detect(
		int nLayer, 
		Movable * pMovable, 
		Stack * stack, 
		list<Space *> * space, 
		XMFLOAT3 vecDifferential);

protected:
	int Calculate(
		int nLayer, 
		Movable * pMovable, 
		Stack * stack, 
		list<Space *> * retVal,
		XMFLOAT3 vecDifferential);

	bool IsClose(
		Movable * pMovable, 
		Space * data,
		XMFLOAT3 vecDifferential);

private:
};