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
#include "Space.h"

using namespace std;

class Layer
{
public:
	Layer() { m_spaces = new vector<Space *>(); }
	void Add(Space * space) { m_spaces->push_back(space); }
	vector<Space *> * GetSpaces() { return m_spaces; }
	void Clear() { m_spaces->clear(); }

protected:

private:
	vector<Space *> * m_spaces;
};
