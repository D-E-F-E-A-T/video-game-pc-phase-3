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
#include "Renderable.h"
#include "..\Common\DeviceResources.h"
#include "Wireframe.h"

class Renderable3D : public Renderable
{
public:
	Renderable3D(
		const shared_ptr<DeviceResources>& deviceResources,
		Wireframe * pWireframe)
		: Renderable(deviceResources, pWireframe)
	{
	}

	//Renderable3D()
	//{
	//	m_pfBounds = new float[3];
	//}

protected:

private:
};
