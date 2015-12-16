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
#include "Stack.h"
#include "..\Constants.h"

Stack::Stack()
{
	// Layer[0] will always be the Player layer.

	for (int i = 0; i < NUM_LAYERS; i++)
	{
		m_layers[i] = new Layer();
	}
}

// Idea: Keep only one player layer.
void Stack::Add(int depth, Space * space)
{
	//if (depth == LAYER_PLAYERS)
	//{
	//	if (m_layers[depth]->GetSpaces()->size() > 0)
	//	{
	//		return;
	//	}
	//}

	Layer * layer = m_layers[depth];

	m_layers[depth]->Add(space);
}

Layer * Stack::Get(int depth)
{
	return m_layers[depth];
}

void Stack::Clear()
{
	for (int i = LAYER_MOVABLES; i < NUM_LAYERS; i++)
	{
		m_layers[i]->Clear();
	}
}