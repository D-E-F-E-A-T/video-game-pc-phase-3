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
				ServiceProxy::BuildCommand ^ pProxyCommand = (*iterator)->GetBuildCommand();

				BuildCommand * pCommand = nullptr;

				if (pProxyCommand->Type == ADD_BORDER_COMMAND)
				{
					pCommand = new AddBorderCommand();
				}
				else if (pProxyCommand->Type == ADD_EDGE_COMMAND)
				{
					pCommand = new AddEdgeCommand();
				}
				else if (pProxyCommand->Type == ADD_FOREST_COMMAND)
				{
					pCommand = new AddForestCommand();
				}
				else if (pProxyCommand->Type == ADD_GRASS_COMMAND)
				{
					pCommand = new AddGrassCommand();
				}
				else if (pProxyCommand->Type == ADD_ROCK_COMMAND)
				{
					pCommand = new AddRockCommand();
				}
				else if (pProxyCommand->Type == ADD_STAIRS_COMMAND)
				{
					pCommand = new AddStairsCommand();
				}
				else if (pProxyCommand->Type == ADD_STONEWALL_COMMAND)
				{
					pCommand = new AddStoneWallCommand();
				}
				else if (pProxyCommand->Type == ADD_TREE_COMMAND)
				{
					pCommand = new AddTreeCommand();
				}
				else if (pProxyCommand->Type == ADD_WATER_COMMAND)
				{
					pCommand = new AddWaterCommand();
				}

				pCommand->Process(
					pWorld,
					fScreenDimensions,
					nullptr,
					pSubdivision,
					deviceResources);
			}
		}
	}

protected:

private:
};
