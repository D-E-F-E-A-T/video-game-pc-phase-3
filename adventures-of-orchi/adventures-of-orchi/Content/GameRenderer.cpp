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
#include "GameRenderer.h"

#include "..\Common\DirectXHelper.h"
#include "LeftMargin.h"
#include "RightMargin.h"
#include "..\Model\VectorGraphic.h"
#include "..\Model\Edge.h"
#include "Utils.h"
#include "..\Model\Texture.h"
#include "..\Model\Tree.h"

using namespace adventures_of_orchi;
using namespace DirectX;
using namespace Windows::Foundation;
using namespace std;
using namespace DX;
using namespace Windows::UI::ViewManagement;



GameRenderer::GameRenderer(const shared_ptr<DeviceResources>& deviceResources, CoreWindow ^ window) :
	m_degreesPerSecond(45),
	m_indexCount(0),
	m_deviceResources(deviceResources)
{
	m_window = window;

	CreateDeviceDependentResources();
	CreateWindowSizeDependentResources();


	m_fWindowWidth = m_window->Bounds.Width;
	m_fWindowHeight = m_window->Bounds.Height;

	grid.SetWindowWidth(m_window->Bounds.Width);
	grid.SetWindowHeight(m_window->Bounds.Height);
	grid.SetNumColumns(NUM_GRID_COLUMNS);
	grid.SetNumRows(NUM_GRID_ROWS);

	m_pWorld = m_worldFactory.Build(
		float2{ m_fWindowWidth, m_fWindowHeight },
		m_deviceResources);

	m_pRegion = m_pWorld->LoadRegion(0);
	m_pCurrentSubdivision = m_pRegion->LoadSubdivision(2, 2);

	m_pPlayer = new Player(
		float2(0.5f, 0.5f),	// This is the centroid of the player.
		0.f,
		float2
		{
			Utils::CalculateSquareWidthRatio(m_fWindowWidth),
			Utils::CalculateSquareHeightRatio(m_fWindowHeight)
		},
		true,
		deviceResources);

	m_pSword = new Sword(
		m_pPlayer->GetLocationRatio(),
		0.f,
		m_deviceResources);

	m_pCurrentSubdivision->GetStack()->Add(LAYER_PLAYERS, m_pPlayer);
	m_pCurrentSubdivision->GetStack()->Add(LAYER_PLAYERS, m_pSword);

	m_nHeading = NORTH;

	m_pCollided = new list<Space *>;
	m_pFilteredCollided = new list<Space *>;

	m_pKeyboardStack = new list<String ^>;
}

// Initializes view parameters when the window size changes.
void GameRenderer::CreateWindowSizeDependentResources()
{
	Size outputSize = m_deviceResources->GetOutputSize();
	float aspectRatio = outputSize.Width / outputSize.Height;
	float fovAngleY = 70.0f * XM_PI / 180.0f;

	// This is a simple example of change that can be made when the app is in
	// portrait or snapped view.
	if (aspectRatio < 1.0f)
	{
		fovAngleY *= 2.0f;
	}

	// Note that the OrientationTransform3D matrix is post-multiplied here
	// in order to correctly orient the scene to match the display orientation.
	// This post-multiplication step is required for any draw calls that are
	// made to the swap chain render target. For draw calls to other targets,
	// this transform should not be applied.

	// This sample makes use of a right-handed coordinate system using row-major matrices.
	XMMATRIX perspectiveMatrix = XMMatrixPerspectiveFovRH(
		fovAngleY,
		aspectRatio,
		0.01f,
		100.0f
		);

	XMFLOAT4X4 orientation = m_deviceResources->GetOrientationTransform3D();

	XMMATRIX orientationMatrix = XMLoadFloat4x4(&orientation);

	DirectX::XMStoreFloat4x4(
		&m_constantBufferData.projection,
		XMMatrixTranspose(perspectiveMatrix * orientationMatrix)
		);

	// Eye is at (0,0.7,1.5), looking at point (0,-0.1,0) with the up-vector along the y-axis.
	static const XMVECTORF32 eye = { 0.0f, 0.7f, 1.5f, 0.0f };
	static const XMVECTORF32 at = { 0.0f, -0.1f, 0.0f, 0.0f };
	static const XMVECTORF32 up = { 0.0f, 1.0f, 0.0f, 0.0f };

	DirectX::XMStoreFloat4x4(&m_constantBufferData.view, XMMatrixTranspose(XMMatrixLookAtRH(eye, at, up)));

	m_infoPanels = new vector<InfoPanel *>;

	m_infoPanels->push_back(&m_lifePanel);
	m_infoPanels->push_back(&m_buttonsPanel);
	m_infoPanels->push_back(&m_mapPanel);
	m_infoPanels->push_back(&m_inventoryPanel);
	m_infoPanels->push_back(&m_packPanel);

	m_infoPanels->at(0)->CreateText(
		"Life",
		float2{ m_window->Bounds.Width, m_window->Bounds.Height },
		m_deviceResources);

	m_infoPanels->at(1)->CreateText(
		"Buttons",
		float2{ m_window->Bounds.Width, m_window->Bounds.Height },
		m_deviceResources);

	m_infoPanels->at(2)->CreateText(
		"Map",
		float2{ m_window->Bounds.Width, m_window->Bounds.Height },
		m_deviceResources);

	m_infoPanels->at(3)->CreateText(
		"Inventory",
		float2{ m_window->Bounds.Width, m_window->Bounds.Height },
		m_deviceResources);

	m_infoPanels->at(4)->CreateText(
		"Pack",
		float2{ m_window->Bounds.Width, m_window->Bounds.Height },
		m_deviceResources);
}


bool GameRenderer::OnControllerInput()
{
	bool retVal = false;

	// if the gamepad is not connected, check the keyboard.
	if (m_xboxController.GetIsControllerConnected())
	{
		// This would actually, detect a collision one interation
		//	too late.  Consider detection earlier since
		//	this could lead to weird behavior, depending
		//	on how fast the sprites are moving.
		//	For example, if sprites are moving very quickly,
		//	collision would occur when the sprites 
		//	have deeply intersected each other.
		//  For slow moving sprites, this would not be 
		//	much of a problem.
		retVal = m_xboxController.MovePlayer(
			m_pPlayer,
			m_nCollisionState,
			&m_nHeading);

		// Temporary.
//		if (m_xboxController.CheckAButton())
//			ThrowSword(m_nHeading);
	}
	else // Use the Touch Screen controls
	{
		for (int i = NORTH; i <= WEST; i++)
		{
			if (m_bTouchScreenButtonPressed[i])
			{
				m_pPlayer->Move(i, m_nCollisionState, PLAYER_MOVE_VELOCITY);
				m_nHeading = i;
				retVal = true;
				break;
			}
		}

		// Temporary.
		//if (m_bTouchScreenButtonPressed[A_BUTTON])
		//	ThrowSword(m_nHeading);
	}

	return retVal;
}

// Called once per frame, rotates the cube and calculates the model and view matrices.
int GameRenderer::Update(DX::StepTimer const& timer)
{
	m_nFramesPerSecond = timer.GetFramesPerSecond();

	// Not handling portrait mode for this release.
	if (m_nOrientation == PORTRAIT)
		return 1;

	int columns = 0;
	int rows = 0;

	m_pRegion->GetDimensions(&columns, &rows);
	((MapPanel *)m_infoPanels->at(2))->SetDimensions(columns, rows);

	int nCurrentColumn = 0;
	int nCurrentRow = 0;
	m_pRegion->GetLocation(&nCurrentColumn, &nCurrentRow);
	((MapPanel *)m_infoPanels->at(2))->SetLocation(nCurrentColumn, nCurrentRow);

	// DO NOT USE m_window HERE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

	m_xboxController.FetchControllerInput();

	bool bMoveInputReady = false;

	bMoveInputReady = OnControllerInput();
	bMoveInputReady |= HandleKeyboardQueue();

	// Temporary.
	// UpdateSword();

	// Need to do collision calculations by looking ahead.
	//	Don't actually move the player until the 
	//	safe distance has been pre-calculated.

	// Only use collision detection if there 
	//	 the User wants to move.
	if (bMoveInputReady)
	{
		m_broadCollisionDetectionStrategy.Detect(
			LAYER_2D,
			m_pPlayer,
			m_pCurrentSubdivision->GetStack(),
			m_pCollided,
			&(XMFLOAT3{ 0.0f, 0.0f, 0.0f }),
			&grid);

		// Idea: Precedence order of collided objects.
		//	For example, if colliding with a tree
		//	and a portal, then the Portal takes precedence.

		// Edges need to be touched.
		Space * pCollidedEdge = m_portalCollisionDetectionStrategy.Detect(
			m_pPlayer,
			m_pCollided);

		if (pCollidedEdge)
		{
			int minIndex = 0;

			int nDirection = static_cast<Edge *>(pCollidedEdge)->GetDirection();

			m_pPlayer->Skip(nDirection, float2{ m_fWindowWidth, m_fWindowHeight });
			m_pCurrentSubdivision = m_pRegion->Slide(nDirection);

			m_pCurrentSubdivision->GetStack()->Add(LAYER_PLAYERS, m_pPlayer);
			m_pCurrentSubdivision->GetStack()->Add(LAYER_PLAYERS, m_pSword);

			m_pCollided->clear();

			return 0;
		}

#ifdef _DEBUG
		m_collidedRects.clear();
		m_collidedRectStatuses.clear();
#endif // _DEBUG

		m_pCollided->clear();

		m_broadCollisionDetectionStrategy.Detect(
			LAYER_PORTALS,
			m_pPlayer,
			m_pCurrentSubdivision->GetStack(),
			m_pCollided,
			&(XMFLOAT3{ 0.0f, 0.0f, 0.0f }),
			&grid);

		// First, look for any collided stairs.
		Space * pCollidedStairs = m_portalCollisionDetectionStrategy.Detect(
			m_pPlayer,
			m_pCollided);

		if (pCollidedStairs)
		{
			int nDestination = static_cast<Portal *>(pCollidedStairs)->GetDestination();

			m_pRegion = m_pWorld->Go(nDestination);

			int entryX = 0;
			int entryY = 0;

			m_pRegion->GetEntry(&entryX, &entryY);

			m_pCurrentSubdivision =
				m_pRegion->LoadSubdivision(entryX, entryY);

			m_pCurrentSubdivision->GetStack()->Add(LAYER_PLAYERS, m_pPlayer);
			m_pCurrentSubdivision->GetStack()->Add(LAYER_PLAYERS, m_pSword);

			m_nHeading = SOUTH;

			m_pCollided->clear();

			return 0;
		}

		m_pCollided->clear();

		// If FPS = 1, velocity = 5,
		//	magnitude = 0.2f
		XMFLOAT3 vec3Differential = m_lookaheadVectorCalculator.Calculate(
			m_pPlayer,
			m_nHeading,
			float2{ m_fWindowWidth, m_fWindowHeight },
			WALKING_VELOCITY,
			1, // timer.GetFramesPerSecond(),
			&grid,
			m_rectLookaheadZonePixels,
			&m_fLookaheadPt);

#ifdef _DEBUG
		m_vecDifferential = XMLoadFloat3(&vec3Differential);

		float fMagnitude = XMVectorGetX(XMVector3Length(m_vecDifferential));

		if (fMagnitude > 0.0f)
		{
			char buffer1[64];

			sprintf_s(
				buffer1,
				"Lookahead: (Heading %d) (Magnitude %f)\n",
				m_nHeading,
				fMagnitude);

			OutputDebugStringA(buffer1);
		}
#endif // _DEBUG

		m_broadCollisionDetectionStrategy.Detect(
			LAYER_COLLIDABLES,
			m_pPlayer,
			m_pCurrentSubdivision->GetStack(),
			m_pCollided,
			&vec3Differential,
			&grid);

		if (m_pCollided->size() > 0)
		{
			m_lookaheadCollisionFilter.Filter(
				m_pFilteredCollided,
				m_pCollided,
				float2{ m_fWindowWidth, m_fWindowHeight },
				m_rectLookaheadZonePixels);

			std::list<Space *>::const_iterator iterator;

			// !!!!!!!!
			// Need to know which of the collided spaces
			//	would be collided with first.
			//	For example, if the Player is approaching
			// three trees that are in a horizontal line
			//	from the left.  
			//	This algorithm would be incorrect to
			//	try to use the right-most tree.
			//	Instead, the left-most tree must be used.
			// !!!!!!!
			if (m_pFilteredCollided->size() > 0)
			{
				Space * pNearestSpace = m_pFilteredCollided->front();
				float fNearestDistance = m_pPlayer->CalculateDistance(pNearestSpace);

				for (iterator = next(m_pFilteredCollided->begin());
				iterator != m_pFilteredCollided->end();
					iterator++)
				{
					if (m_pPlayer->CalculateDistance(*iterator) < fNearestDistance)
						pNearestSpace = (*iterator);
				}

				int intersectRect[4];

#ifdef _DEBUG
				// m_pPlayer will be modified, if needed
				m_lookaheadCollisionDetectionStrategy.Detect(
					m_pPlayer,
					pNearestSpace,
					&grid,
					intersectRect,
					float2(m_fWindowWidth, m_fWindowHeight),
					&vec3Differential,
					m_nHeading,
					m_fLookaheadPt,
					&m_collidedRects,
					&m_collidedRectStatuses);
#else
				m_lookaheadCollisionDetectionStrategy.Detect(
					m_pPlayer,
					*iterator,
					&grid,
					intersectRect,
					float2(m_fWindowWidth, m_fWindowHeight),
					&vec3Differential,
					m_nHeading,
					m_fLookaheadPt,
					nullptr,
					nullptr);
#endif // _DEBUG

#ifdef _DEBUG
			}

			m_bLookaheadValid = true;
#endif // _DEBUG
		}
#ifdef _DEBUG
		else
		{
			m_bLookaheadValid = false;
		}
#endif // _DEBUG

		return 1;
	}

	return 0;
}

// Renders one frame using the vertex and pixel shaders.
void GameRenderer::Render()
{
	if (m_nOrientation == PORTRAIT)
	{
		DEVICE_CONTEXT_2D->BeginDraw();

		DEVICE_CONTEXT_2D->Clear(D2D1::ColorF(D2D1::ColorF::BlanchedAlmond));
		HRESULT hr = DEVICE_CONTEXT_2D->EndDraw();

		return;
	}

	D2D1_SIZE_F renderTargetSize = DEVICE_CONTEXT_2D->GetSize();

	DEVICE_CONTEXT_2D->BeginDraw();

	float fScreenDimensions[]
	{ 
		m_fWindowWidth, 
		m_fWindowHeight 
	};

	m_pCurrentSubdivision->Render(fScreenDimensions, &grid, m_deviceResources);
	DEVICE_CONTEXT_2D->SetTransform(D2D1::Matrix3x2F::Identity());

	DrawLeftMargin();
	DrawRightMargin();

	std::vector<InfoPanel *>::const_iterator iterInfoPanels;

	for (iterInfoPanels = m_infoPanels->begin(); iterInfoPanels != m_infoPanels->end(); iterInfoPanels++)
	{
		(*iterInfoPanels)->Render(m_deviceResources);
	}


#ifdef _DEBUG
	grid.SetVisibility(true);
#endif // _DEBUG

	grid.Draw(
		DEVICE_CONTEXT_2D, 
		m_deviceResources,
		m_nFramesPerSecond);

	RenderSpaces2D();

#ifdef _DEBUG

	std::list<Space *>::const_iterator iterator;

	for (iterator = m_pCollided->begin(); iterator != m_pCollided->end(); iterator++)
	{
		int column = 0;
		int row = 0;

		float fX = 0.f;
		float fY = 0.f;

		Utils::ConvertGlobalToGridLocation((*iterator)->GetLocationRatio(), &fX, &fY);

		Utils::ConvertRatioToGridLocations(
			grid,
			float2{ fX, fY },
			&column,
			&row);

		HighlightRegion(
			column,
			row,
			m_deviceResources->m_mapBrushes["yellow"]);
	}

	DrawLookaheadZone();
	DrawSpriteIntersection();
	DrawFilteredCollided();
	DrawBroadCollisionZone();

#endif // _DEBUG

	// If a gamepad is connected, never use the touchscreen controls.
	if (m_xboxController.GetIsControllerConnected() == false &&
		m_uiMode == UserInteractionMode::Touch)
	{
		m_touchScreenController.RenderButtonTouchControls(
			float2{ m_fWindowWidth, m_fWindowHeight },
			m_bTouchScreenButtonPressed[X_BUTTON],
			m_bTouchScreenButtonPressed[Y_BUTTON],
			m_bTouchScreenButtonPressed[A_BUTTON],
			m_bTouchScreenButtonPressed[B_BUTTON],
			m_deviceResources);

		m_touchScreenController.RenderDirectionalTouchControls(
			float2{ m_fWindowWidth, m_fWindowHeight },
			m_bTouchScreenButtonPressed[NORTH_BUTTON],
			m_bTouchScreenButtonPressed[EAST_BUTTON],
			m_bTouchScreenButtonPressed[SOUTH_BUTTON],
			m_bTouchScreenButtonPressed[WEST_BUTTON],
			m_deviceResources);
	}

	HRESULT hr = DEVICE_CONTEXT_2D->EndDraw();
	
	RenderSpaces3D();

	m_pCollided->clear();
	m_pFilteredCollided->clear();

#ifdef _DEBUG
	m_collidedRects.clear();
	m_collidedRectStatuses.clear();
#endif // _DEBUG


}

void GameRenderer::CreateDeviceDependentResources()
{
	// Load shaders asynchronously.
	auto loadVSTask = DX::ReadDataAsync(L"SampleVertexShader.cso");
	auto loadPSTask = DX::ReadDataAsync(L"SamplePixelShader.cso");

	// After the vertex shader file is loaded, create the shader and input layout.
	auto createVSTask = loadVSTask.then([this](const std::vector<byte>& fileData) {
		DX::ThrowIfFailed(
			DEVICE_3D->CreateVertexShader(
				&fileData[0],
				fileData.size(),
				nullptr,
				&m_vertexShader
				)
			);

		static const D3D11_INPUT_ELEMENT_DESC vertexDesc [] =
		{
			{ "POSITION", 0, DXGI_FORMAT_R32G32B32_FLOAT, 0, 0, D3D11_INPUT_PER_VERTEX_DATA, 0 },
			{ "COLOR", 0, DXGI_FORMAT_R32G32B32_FLOAT, 0, 12, D3D11_INPUT_PER_VERTEX_DATA, 0 },
		};

		DX::ThrowIfFailed(
			DEVICE_3D->CreateInputLayout(
				vertexDesc,
				ARRAYSIZE(vertexDesc),
				&fileData[0],
				fileData.size(),
				&m_inputLayout
				)
			);
	});

	// After the pixel shader file is loaded, create the shader and constant buffer.
	auto createPSTask = loadPSTask.then([this](const std::vector<byte>& fileData) {
		DX::ThrowIfFailed(
			DEVICE_3D->CreatePixelShader(
				&fileData[0],
				fileData.size(),
				nullptr,
				&m_pixelShader
				)
			);

		CD3D11_BUFFER_DESC constantBufferDesc(sizeof(ModelViewProjectionConstantBuffer) , D3D11_BIND_CONSTANT_BUFFER);
		DX::ThrowIfFailed(
			DEVICE_3D->CreateBuffer(
				&constantBufferDesc,
				nullptr,
				&m_constantBuffer
				)
			);
	});

	// Once both shaders are loaded, create the mesh.
	auto createCubeTask = (createPSTask && createVSTask).then([this] () {

		// Load mesh vertices. Each vertex has a position and a color.
		static const VertexPositionColor cubeVertices[] = 
		{
			{XMFLOAT3(-0.5f, -0.5f, -0.5f), XMFLOAT3(0.0f, 0.0f, 0.0f)},
			{XMFLOAT3(-0.5f, -0.5f,  0.5f), XMFLOAT3(0.0f, 0.0f, 1.0f)},
			{XMFLOAT3(-0.5f,  0.5f, -0.5f), XMFLOAT3(0.0f, 1.0f, 0.0f)},
			{XMFLOAT3(-0.5f,  0.5f,  0.5f), XMFLOAT3(0.0f, 1.0f, 1.0f)},
			{XMFLOAT3( 0.5f, -0.5f, -0.5f), XMFLOAT3(1.0f, 0.0f, 0.0f)},
			{XMFLOAT3( 0.5f, -0.5f,  0.5f), XMFLOAT3(1.0f, 0.0f, 1.0f)},
			{XMFLOAT3( 0.5f,  0.5f, -0.5f), XMFLOAT3(1.0f, 1.0f, 0.0f)},
			{XMFLOAT3( 0.5f,  0.5f,  0.5f), XMFLOAT3(1.0f, 1.0f, 1.0f)},
		};

		D3D11_SUBRESOURCE_DATA vertexBufferData = {0};
		vertexBufferData.pSysMem = cubeVertices;
		vertexBufferData.SysMemPitch = 0;
		vertexBufferData.SysMemSlicePitch = 0;
		CD3D11_BUFFER_DESC vertexBufferDesc(sizeof(cubeVertices), D3D11_BIND_VERTEX_BUFFER);
		DX::ThrowIfFailed(
			DEVICE_3D->CreateBuffer(
				&vertexBufferDesc,
				&vertexBufferData,
				&m_vertexBuffer
				)
			);

		// Load mesh indices. Each trio of indices represents
		// a triangle to be rendered on the screen.
		// For example: 0,2,1 means that the vertices with indexes
		// 0, 2 and 1 from the vertex buffer compose the 
		// first triangle of this mesh.
		static const unsigned short cubeIndices [] =
		{
			0,2,1, // -x
			1,2,3,

			4,5,6, // +x
			5,7,6,

			0,1,5, // -y
			0,5,4,

			2,6,7, // +y
			2,7,3,

			0,4,6, // -z
			0,6,2,

			1,3,7, // +z
			1,7,5,
		};

		m_indexCount = ARRAYSIZE(cubeIndices);

		D3D11_SUBRESOURCE_DATA indexBufferData = {0};
		indexBufferData.pSysMem = cubeIndices;
		indexBufferData.SysMemPitch = 0;
		indexBufferData.SysMemSlicePitch = 0;
		CD3D11_BUFFER_DESC indexBufferDesc(sizeof(cubeIndices), D3D11_BIND_INDEX_BUFFER);
		DX::ThrowIfFailed(
			DEVICE_3D->CreateBuffer(
				&indexBufferDesc,
				&indexBufferData,
				&m_indexBuffer
				)
			);
	});

	// Once the cube is loaded, the object is ready to be rendered.
	//createCubeTask.then([this] () {
	//	m_loadingComplete = true;
	//});
}

void GameRenderer::ReleaseDeviceDependentResources()
{
}


// @see: http://www.gamedev.net/topic/603359-c-dx11-how-to-get-texture-size/
void GameRenderer::RenderSpaces3D()
{
	ComPtr<ID3D11RenderTargetView> renderTargetView;

	// Get the target associated with the back buffer.
	// Select the scratch buffer for drawing sprites.
	DEVICE_CONTEXT_3D->OMGetRenderTargets(
		1,
		&renderTargetView,
		nullptr
		);

	int numLayers = m_pCurrentSubdivision->GetStack()->GetNumLayers();

	for (int i = LAYER_BACKGROUND; i >= LAYER_PLAYERS; i--)
	{
		Layer * currentLayer = m_pCurrentSubdivision->GetStack()->Get(i);

		vector<Space *>::const_iterator iterator;

		// This is a sprite run.
		for (iterator = currentLayer->GetSpaces()->begin(); 
			iterator != currentLayer->GetSpaces()->end(); 
			iterator++)
		{
			float fColumnWidth = grid.GetColumnWidth();
			float fRowHeight = grid.GetRowHeight();

			float dpi = m_deviceResources->GetDpi();

			(*iterator)->Render(
				renderTargetView,
				float2(m_fWindowWidth, m_fWindowHeight),
				float2(fColumnWidth, fRowHeight),
				dpi);
		}
	}

	// Copy from the scratch buffer to the back buffer.
	// Create a bitmap and copy??? http://xboxforums.create.msdn.com/forums/p/84925/511738.aspx
}




#ifdef _DEBUG
void GameRenderer::DrawBroadCollisionZone()
{
	float fMagnitude = XMVectorGetX(XMVector3Length(m_vecDifferential));
	float fRadius = 0.0f;

	float2 fGridPixels =
	{
		m_fWindowWidth * (1.0f - LEFT_MARGIN_RATIO - RIGHT_MARGIN_RATIO),
		m_fWindowHeight * (1.0f - TOP_MARGIN_RATIO - BOTTOM_MARGIN_RATIO)
	};

	float fRadiusX = fMagnitude * fGridPixels.x;
	float fRadiusY = fMagnitude * fGridPixels.y;

	D2D1_ELLIPSE ellipse
	{
		D2D1_POINT_2F
		{
			(m_pPlayer->GetLocationRatio().x * m_fWindowWidth) + 
				(XMVectorGetX(m_vecDifferential) * fGridPixels.x),
			(m_pPlayer->GetLocationRatio().y * m_fWindowHeight) +
				(XMVectorGetY(m_vecDifferential) * fGridPixels.y)
		},
		fRadiusX,
		fRadiusY
	};

	DEVICE_CONTEXT_2D->DrawEllipse(
		ellipse,
		m_deviceResources->m_mapBrushes["purple"],
		3.0f);
}

void GameRenderer::DrawFilteredCollided()
{
	list<Space *>::const_iterator iterator;

	for (iterator = m_pFilteredCollided->begin(); 
		iterator != m_pFilteredCollided->end(); 
		iterator++)
	{
		D2D1_ELLIPSE ellipse
		{
			D2D1_POINT_2F
			{
				(*iterator)->GetLocationRatio().x * m_fWindowWidth,
				(*iterator)->GetLocationRatio().y * m_fWindowHeight,
			},
			m_fWindowWidth * BUTTON_SIZE_RATIO * 0.75f,
			m_fWindowWidth * BUTTON_SIZE_RATIO * 0.75f
		};

		DEVICE_CONTEXT_2D->FillEllipse(
			ellipse,
			m_deviceResources->m_mapBrushes["limegreen"]);
	}
}

void GameRenderer::DrawLookaheadZone()
{
	if (m_bLookaheadValid)
	{
		float fMagnitude = XMVectorGetX(XMVector3Length(m_vecDifferential));
		float fRadius = 0.0f;

		float2 fGridPixels =
		{
			m_fWindowWidth * (1.0f - LEFT_MARGIN_RATIO - RIGHT_MARGIN_RATIO),
			m_fWindowHeight * (1.0f - TOP_MARGIN_RATIO - BOTTOM_MARGIN_RATIO)
		};

		D2D1_ELLIPSE ellipse
		{
			D2D1_POINT_2F
			{
				(m_pPlayer->GetLocationRatio().x * m_fWindowWidth) +
					(XMVectorGetX(m_vecDifferential) * fGridPixels.x),
				(m_pPlayer->GetLocationRatio().y * m_fWindowHeight) +
					(XMVectorGetY(m_vecDifferential) * fGridPixels.y)
			},
			m_fWindowWidth * 0.0025f,
			m_fWindowWidth * 0.0025f
		};

		DEVICE_CONTEXT_2D->FillEllipse(
			ellipse,
			m_deviceResources->m_mapBrushes["purple"]);

		DEVICE_CONTEXT_2D->DrawRectangle(
			D2D1_RECT_F
			{
				m_rectLookaheadZonePixels[BOUNDS_LEFT],
				m_rectLookaheadZonePixels[BOUNDS_TOP],
				m_rectLookaheadZonePixels[BOUNDS_RIGHT],
				m_rectLookaheadZonePixels[BOUNDS_BOTTOM]
			},
			m_deviceResources->m_mapBrushes["purple"],
			1.0f);
	}
}
#endif // _DEBUG

#ifdef _DEBUG
void GameRenderer::DrawSpriteIntersection()
{
	std::vector<D2D1_RECT_F>::const_iterator iterator;
	std::vector<int>::const_iterator iterator2;

	iterator2 = m_collidedRectStatuses.begin();

	for (iterator = m_collidedRects.begin(); iterator != m_collidedRects.end(); iterator++)
	{
		if ((*iterator2) == INTERSECTION)
		{
			DEVICE_CONTEXT_2D->FillRectangle(
				(*iterator),
				m_deviceResources->m_mapBrushes["green"]);
		}
		else if ((*iterator2) == COLLISION)
		{
			DEVICE_CONTEXT_2D->FillRectangle(
				(*iterator),
				m_deviceResources->m_mapBrushes["red"]);
		}
	}
}
#endif // _DEBUG

#ifdef _DEBUG
void GameRenderer::HighlightRegion(int * pLocation, ComPtr<ID2D1SolidColorBrush> brush)
{
	if (pLocation)
		HighlightRegion(
			pLocation[HORIZONTAL_AXIS],
			pLocation[VERTICAL_AXIS], brush);
}
#endif // DEBUG

/*
Highlight the sprite that is being collided with.
*/
#ifdef _DEBUG
void GameRenderer::HighlightRegion(int column, int row, ComPtr<ID2D1SolidColorBrush> brush)
{
	float x = 0.0f;
	float y = 0.0f;

	Utils::CalculateSquareCenter(
		m_fWindowWidth,
		m_fWindowHeight,
		column,
		row,
		&x,
		&y);

	x *= m_fWindowWidth;
	y *= m_fWindowHeight;
	
	float gameAreaWidth =
		m_fWindowWidth -
		(m_fWindowWidth * LEFT_MARGIN_RATIO) -
		(m_fWindowWidth * RIGHT_MARGIN_RATIO);

	float gameAreaHeight = m_fWindowHeight;

	D2D1_RECT_F rect
	{
		x - (gameAreaWidth / (float)NUM_GRID_COLUMNS) / 2.0f,
		y - m_fWindowHeight / (float)NUM_GRID_ROWS / 2.0f,
		x + (gameAreaWidth / (float)NUM_GRID_COLUMNS) / 2.0f,
		y + m_fWindowHeight / (float)NUM_GRID_ROWS / 2.0f
	};


	m_deviceResources->GetD2DDeviceContext()->FillRectangle(
		rect,
		brush.Get());
}
#endif // _DEBUG

// Handle keystrokes in main loop to keep it synchronous with
//	the controller and touch screen inputs.
void GameRenderer::OnKeyDown(Windows::UI::Core::KeyEventArgs^ args)
{
	if (args->VirtualKey == Windows::System::VirtualKey::P)
	{
//		m_pKeyboardStack->push_front("P");
	}
	else if (args->VirtualKey == Windows::System::VirtualKey::S)
	{
		m_pKeyboardStack->push_front("S");
	}
	else if (args->VirtualKey == Windows::System::VirtualKey::Left)
	{
		m_pKeyboardStack->push_front("Left");
	}
	else if (args->VirtualKey == Windows::System::VirtualKey::Down)
	{
		m_pKeyboardStack->push_front("Down");
	}
	else if (args->VirtualKey == Windows::System::VirtualKey::Right)
	{
		m_pKeyboardStack->push_front("Right");
	}
	else if (args->VirtualKey == Windows::System::VirtualKey::Up)
	{
		m_pKeyboardStack->push_front("Up");
	}
}


void GameRenderer::OnSizeChanged(
	WindowSizeChangedEventArgs^ args,
	UserInteractionMode uiMode)
{
	grid.SetWindowWidth(m_window->Bounds.Width);
	grid.SetWindowHeight(m_window->Bounds.Height);

	m_fWindowWidth = m_window->Bounds.Width;
	m_fWindowHeight = m_window->Bounds.Height;

	if (m_fWindowWidth > m_fWindowHeight)
		m_nOrientation = LANDSCAPE;
	else
		m_nOrientation = PORTRAIT;

	m_uiMode = uiMode;
}

void GameRenderer::SetUserInteractionMode(UserInteractionMode uiMode)
{
	m_uiMode = uiMode;
}


void GameRenderer::DrawLeftMargin()
{
	LeftMargin leftMargin;

	D2D1_RECT_F rect
	{
		0.0f,
		0.0f,
		m_fWindowWidth * LEFT_MARGIN_RATIO,
		m_fWindowHeight
	};

	leftMargin.Draw(
		DEVICE_CONTEXT_2D,
		m_deviceResources->m_mapBrushes["black"],
		rect);
}

void GameRenderer::DrawRightMargin()
{
	RightMargin rightMargin;

	D2D1_RECT_F rect
	{
		m_fWindowWidth - (m_fWindowWidth * RIGHT_MARGIN_RATIO),
		0.0f,
		m_fWindowWidth,
		m_fWindowHeight
	};

	rightMargin.Draw(
		DEVICE_CONTEXT_2D,
		m_deviceResources->m_mapBrushes["black"],
		rect);
}



void GameRenderer::RenderSpaces2D()
{
	Layer * currentLayer = m_pCurrentSubdivision->GetStack()->Get(LAYER_2D);

	vector<Space *>::const_iterator iterator;

	// This is a sprite run.
	for (iterator = currentLayer->GetSpaces()->begin();
	iterator != currentLayer->GetSpaces()->end();
		iterator++)
	{
		float fColumnWidth = grid.GetColumnWidth();
		float fRowHeight = grid.GetRowHeight();
		float dpi = m_deviceResources->GetDpi();

		(*iterator)->Render(
			nullptr,
			float2(m_fWindowWidth, m_fWindowHeight),
			float2(fColumnWidth, fRowHeight),
			m_deviceResources->GetDpi());
	}
}

void GameRenderer::ThrowSword(int nDirection)
{
	if (m_pSword->IsFlying() == false)
	{
		m_pSword->SetVisibility(true);
		m_pSword->SetLocationRatio(m_pPlayer->GetLocationRatio());

		m_pSword->Aim(nDirection);
	}
}

void GameRenderer::UpdateSword()
{
	if (m_pSword->IsFlying() == true)
	{
		if (m_pSword->GetVisibility() == true)
		{
			m_pSword->Inertia(0.01f);
		}
	}
}


// TODO: Use bit masking.
void GameRenderer::OnPointerReleased()
{
	if (m_bTouchScreenButtonPressed[NORTH_BUTTON] ||
		m_bTouchScreenButtonPressed[EAST_BUTTON] ||
		m_bTouchScreenButtonPressed[SOUTH_BUTTON] ||
		m_bTouchScreenButtonPressed[WEST_BUTTON])
	{
		m_bTouchScreenButtonPressed[NORTH_BUTTON] = false;
		m_bTouchScreenButtonPressed[EAST_BUTTON] = false;
		m_bTouchScreenButtonPressed[SOUTH_BUTTON] = false;
		m_bTouchScreenButtonPressed[WEST_BUTTON] = false;
	}

	if (m_bTouchScreenButtonPressed[Y_BUTTON] ||
		m_bTouchScreenButtonPressed[B_BUTTON] ||
		m_bTouchScreenButtonPressed[A_BUTTON] ||
		m_bTouchScreenButtonPressed[X_BUTTON])
	{
		m_bTouchScreenButtonPressed[Y_BUTTON] = false;
		m_bTouchScreenButtonPressed[B_BUTTON] = false;
		m_bTouchScreenButtonPressed[A_BUTTON] = false;
		m_bTouchScreenButtonPressed[X_BUTTON] = false;
	}
}

void GameRenderer::OnPointerPressed(ResolutionScale resolutionScale, float fX, float fY)
{
	float fScaleFactor = 1.0f; // Recommended value.

	if (m_xboxController.GetIsControllerConnected() == false &&
		m_uiMode == UserInteractionMode::Touch)
	{
		for (int i = 0; i < NUM_BUTTONS; i++)
		{
			if (m_touchScreenController.CheckButton(
				i,
				float2{ m_fWindowWidth, m_fWindowHeight },
				float2{ fX * fScaleFactor, fY * fScaleFactor }))
				m_bTouchScreenButtonPressed[i] = true;
		}
	}
}

// Do this to queue up keyboard requests and make sure
//	keyboard, touch, and controller inputs are
//	handled on the same clock.
// Thread-safety issues?
bool GameRenderer::HandleKeyboardQueue()
{
	if (m_pKeyboardStack->size() > 0)
	{
		int nQueueSize = m_pKeyboardStack->size();

		String ^ strCommand = m_pKeyboardStack->back();
		m_pKeyboardStack->pop_back();

		m_keyboardController.HandleKeystroke(
			m_pPlayer,
			m_nCollisionState,
			strCommand,
			PLAYER_MOVE_VELOCITY,
			&m_nHeading);
		
		// Temporary
		//if (strCommand->Equals("S"))
		//{
		//	ThrowSword(m_nHeading);
		//}
		
		return true;
	}
	else
	{
		return false;
	}
}