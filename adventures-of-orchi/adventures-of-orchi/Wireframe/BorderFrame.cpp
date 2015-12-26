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
#include "BorderFrame.h"


BorderFrame::BorderFrame()
{
	list<XMFLOAT3> * outer = new list<XMFLOAT3>;
	list<XMFLOAT3> * cross1 = new list<XMFLOAT3>;
	list<XMFLOAT3> * cross2 = new list<XMFLOAT3>;


	// Convention to be used, define vertices 
	//	clockwise around around the centroid.
	outer->push_back(XMFLOAT3{
		0.0f, 
		0.0f,
		0.0f });

	outer->push_back(XMFLOAT3{
		1.0f, 
		0.0f,
		0.0f });

	outer->push_back(XMFLOAT3{
		1.0f, 
		1.0f,
		0.0f });

	outer->push_back(XMFLOAT3{
		0.0f, 
		1.0f,
		0.0f });

	outer->push_back(XMFLOAT3{
		0.0f, 
		0.0f,
		0.0f });

	m_pElements.push_back(outer);


	cross1->push_back(XMFLOAT3{
		0.0f,
		0.0f,
		0.0f });

	cross1->push_back(XMFLOAT3{
		1.0f,
		1.0f,
		0.0f });

	m_pElements.push_back(cross1);


	cross2->push_back(XMFLOAT3{
		1.0f,
		0.0f,
		0.0f });

	cross2->push_back(XMFLOAT3{
		0.0f,
		1.0f,
		0.0f });

	m_pElements.push_back(cross2);
}

BorderFrame::~BorderFrame()
{

}