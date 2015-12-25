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
#include "BuildCommand.h"
#include "..\Model\Border.h"
#include "..\Utils.h"
#include "..\Model\World.h"
#include "..\Model\OverlayRepository.h"

class ApplyOverlayCommand : public BuildCommand
{
public:
	void Process(
		World ** pWorld,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pSubdivision,
		const shared_ptr<DeviceResources>& deviceResources)
	{
		OverlayRepository * pOverlayRepository =
			OverlayRepository::GetInstance();

		// Get the items in the overlay.
		Overlay * pOverlay = pOverlayRepository->Get(
			((ServiceProxy::ApplyOverlayCommand ^)command)->Id);

		// Idea: Overlay the + operator to add
		//	an Overlay to a Subdivision.

		// Apply the items to the Subdivision.
		Stack * pStack = pOverlay->GetStack();
		int numLayers = pStack->GetNumLayers();

		for (int i = LAYER_MOVABLES; i < LAYER_2D; i++)
		{
			Layer * pLayer = pStack->Get(i);

			std::vector<Space *>::const_iterator iterator;

			for (iterator = pLayer->GetSpaces()->begin();
			iterator != pLayer->GetSpaces()->end();
				iterator++)
			{

				/*
						(*pSubdivision)->Set(LAYER_COLLIDABLES,
							new Tree(
								float2(x, y),
								0.f,
								float2(1.f, 1.f),
								true,
								deviceResources));
				*/
			}
		}
	}

protected:

private:
};
