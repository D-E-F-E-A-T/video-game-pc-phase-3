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

#include "..\Common\DeviceResources.h"
#include "ShaderStructures.h"
#include "..\Common\StepTimer.h"
#include "Grid.h"
#include "Model\Player.h"
#include "..\Collision\BroadCollisionStrategy.h"
#include "..\Collision\LookaheadCollisionStrategy.h"
#include "Model\Stack.h"
#include "..\Collision\PortalCollisionStrategy.h"
#include "..\Collision\LookaheadCalculator.h"
#include "..\Model\World.h"
#include "Model\Sword.h"
#include "..\InfoPanel\LifePanel.h"
#include "..\InfoPanel\MapPanel.h"
#include "..\InfoPanel\ButtonsPanel.h"
#include "..\InfoPanel\PackPanel.h"
#include "..\InfoPanel\InventoryPanel.h"
#include "..\InfoPanel\InfoPanel.h"
#include "..\Controller\XBoxOneControllerView.h"
#include "..\Factory\WorldFactory.h"
#include "..\Controller\TouchScreenControllerView.h"
#include "..\Controller\KeyboardControllerView.h"
#include "..\Collision\LookaheadCalculator.h"
#include "..\Collision\LookaheadCollisionFilter.h"

using namespace Windows::UI::Core;
using namespace std;
using namespace Microsoft::WRL;
using namespace DX;
using namespace Windows::UI::ViewManagement;
using namespace Windows::Graphics::Display;
using namespace Windows::System;

// This sample renderer instantiates a basic rendering pipeline.
class GameRenderer
{
public:
	GameRenderer(const std::shared_ptr<DeviceResources>& deviceResources, CoreWindow ^ window);
	void OnPointerPressed(ResolutionScale fResolutionScale, float fX, float fY);
	void OnPointerReleased();
	void CreateDeviceDependentResources();
	void CreateWindowSizeDependentResources();
	void ReleaseDeviceDependentResources();
	int Update(DX::StepTimer const& timer);
	void Render();

	void OnKeyDown(KeyEventArgs ^ args);
	void OnSizeChanged(
		WindowSizeChangedEventArgs ^ args,
		UserInteractionMode uiMode);

	Grid grid;

	void DrawLeftMargin();
	void DrawRightMargin();

	void SetUserInteractionMode(UserInteractionMode uiMode);
private:
	// TODO: Move these to Sword.
	void ThrowSword(int nDirection);
	void UpdateSword();

	Platform::Agile<CoreWindow> m_window;

	// Cached pointer to device resources.
	std::shared_ptr<DeviceResources> m_deviceResources;

	// Direct3D resources for cube geometry.
	ComPtr<ID3D11InputLayout>	m_inputLayout;
	ComPtr<ID3D11Buffer>		m_vertexBuffer;
	ComPtr<ID3D11Buffer>		m_indexBuffer;
	ComPtr<ID3D11VertexShader>	m_vertexShader;
	ComPtr<ID3D11PixelShader>	m_pixelShader;
	ComPtr<ID3D11Buffer>		m_constantBuffer;

	// System resources for cube geometry.
	ModelViewProjectionConstantBuffer	m_constantBufferData;
	uint32	m_indexCount;

	// Variables used with the rendering loop.
	float	m_degreesPerSecond;

	Subdivision * m_pCurrentSubdivision;

	void RenderSpaces2D();
	void RenderSpaces3D();

	Player * m_pPlayer;
	Sword * m_pSword;

	float m_fWindowWidth;
	float m_fWindowHeight;

#ifdef _DEBUG
	void DrawSpriteIntersection();
	void DrawLookaheadZone();
	void DrawFilteredCollided();
	void DrawBroadCollisionZone();
#endif // _DEBUG

	int m_nCollisionState;

	int m_nCollidedSpriteColumn;
	int m_nCollidedSpriteRow;

	bool m_bSpriteCollisionDetected;

	BroadCollisionStrategy m_broadCollisionDetectionStrategy;
	PortalCollisionStrategy m_portalCollisionDetectionStrategy;
	LookaheadCalculator m_lookaheadVectorCalculator;
	LookaheadCollisionFilter m_lookaheadCollisionFilter;
	LookaheadCollisionStrategy m_lookaheadCollisionDetectionStrategy;

	list<Space *> * m_pCollided;
	list<Space *> * m_pFilteredCollided;

#ifdef _DEBUG
	void HighlightRegion(int column, int row, ComPtr<ID2D1SolidColorBrush> brush);
	void HighlightRegion(int * pLocation, ComPtr<ID2D1SolidColorBrush> brush);
	vector<D2D1_RECT_F> m_collidedRects;
	vector<int> m_collidedRectStatuses;
	bool m_bLookaheadValid;
	XMVECTOR m_vecDifferential;

#endif // _DEBUG
	float2 m_fLookaheadPt;
	float m_rectLookaheadZonePixels[4];

	DWRITE_TEXT_RANGE m_textRange;

	World * m_pWorld;
	Region * m_pRegion;
	WorldFactory m_worldFactory;

	// This is needed so that the Sword is aimed
	//	in the direction the Player currently faces
	//	and NOT the direction the controller currently
	//	faces.
	int m_nHeading;

	LifePanel m_lifePanel;
	MapPanel m_mapPanel;
	ButtonsPanel m_buttonsPanel;
	PackPanel m_packPanel;
	InventoryPanel m_inventoryPanel;

	vector<InfoPanel *> * m_infoPanels;

	XBoxOneControllerView m_xboxController;
	TouchScreenControllerView m_touchScreenController;
	UserInteractionMode m_uiMode;
	KeyboardControllerView m_keyboardController;

	// TODO: Use bit operations.
	bool m_bTouchScreenButtonPressed[NUM_BUTTONS];

	// TODO: 
	int m_nOrientation;

	LookaheadCalculator m_lookaheadCalculator;
	bool OnControllerInput();

	list<String ^> * m_pKeyboardStack;
	bool HandleKeyboardQueue();
	int m_nFramesPerSecond;
};

