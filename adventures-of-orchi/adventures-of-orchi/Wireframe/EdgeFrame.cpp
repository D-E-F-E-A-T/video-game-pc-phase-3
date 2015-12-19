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
#include "EdgeFrame.h"


// The convention will be to define all vertices
//	within the range [0.0f, 1.0f].  
//	Vector operations will then move the vertices
//	into the correct place and scale based on
//	factors such as screen size.
//	Each line is represented at a list of 3D vertices
//	XMFLOAT3 is used instead of XMFLOAT2 to avoid
//	the extra overhead of converting XMFLOAT3 to
//	XMFLOAT2.
EdgeFrame::EdgeFrame()
{
	list<XMFLOAT3> * frame = new list<XMFLOAT3>;

	// Convention to be used, define vertices 
	//	clockwise around around the centroid.
	frame->push_back(XMFLOAT3{ 
		0.0f, 
		0.0f,
		0.0f });

	frame->push_back(XMFLOAT3{ 
		1.0f, 
		0.0f,
		0.0f });

	frame->push_back(XMFLOAT3{ 
		1.0f, 
		1.0f,
		0.0f });

	frame->push_back(XMFLOAT3{ 
		0.0f, 
		1.0f,
		0.0f });

	frame->push_back(XMFLOAT3{ 
		0.0f, 
		0.0f,
		0.0f });

	m_pElements.push_back(frame);
}

EdgeFrame::~EdgeFrame()
{

}