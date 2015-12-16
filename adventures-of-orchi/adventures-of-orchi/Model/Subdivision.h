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
#include "Stack.h"
#include "..\Grid.h"

class Subdivision
{
public:
	Subdivision()
	{
		m_lpStack = new Stack();
	}

	void SetColor(int nRed, int nGreen, int nBlue)
	{
		m_nRed = nRed;
		m_nGreen = nGreen;
		m_nBlue = nBlue;
	}

	void Set(int layerId, Space * pSpace)
	{
		m_lpStack->Add(layerId, pSpace);
	}

	Stack * GetStack() { return m_lpStack; }

	virtual void Render(
		float lpfScreenDimensions[2],
		Grid * lpGrid,
		const shared_ptr<DeviceResources>& deviceResources) = 0;

protected:
	Stack * m_lpStack;

//	int m_lpnDimensions[2];
//	int m_nCurrentStackIndex;
	int m_nRed;
	int m_nGreen;
	int m_nBlue;

private:
};
