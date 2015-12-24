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
#include "TemplateRepository.h"


TemplateRepository * TemplateRepository::_instance = NULL;

void TemplateRepository::Add(int nId, Template * pTemplate)
{
	m_pTemplates[nId] = pTemplate;
}

void TemplateRepository::Finalize(int id)
{

}

Template * TemplateRepository::Get(int id)
{
	return m_pTemplates[id];
}

