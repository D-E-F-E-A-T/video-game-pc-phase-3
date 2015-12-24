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
#include "Overlay.h"

using namespace std;

class OverlayRepository
{
public:
	
	static OverlayRepository * GetInstance()
	{
		if (_instance == nullptr)
		{
			_instance = new OverlayRepository();
		}

		return _instance;
	}

	void Add(int nId, Overlay * pOverlay);
	void Finalize(int id);
	Overlay * Get(int id);

protected:
	static OverlayRepository * _instance;

	OverlayRepository();

private:
	map<int, Overlay *> m_pOverlays;
};

