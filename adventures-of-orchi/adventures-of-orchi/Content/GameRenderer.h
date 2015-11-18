#pragma once

#include "..\Common\DeviceResources.h"
#include "ShaderStructures.h"
#include "..\Common\StepTimer.h"
#include "Grid.h"
#include "Model\Player.h"
#include "BroadCollisionStrategy.h"
#include "NarrowCollisionStrategy.h"
#include "Model\Stack.h"
#include "..\PortalCollisionStrategy.h"
#include "..\World.h"
#include "Model\Sword.h"
#include "..\LifePanel.h"
#include "..\MapPanel.h"
#include "..\ButtonsPanel.h"
#include "..\PackPanel.h"
#include "..\InventoryPanel.h"
#include "..\InfoPanel.h"
#include "..\Controller\XBoxOneControllerView.h"

using namespace Windows::UI::Core;
using namespace std;
using namespace Microsoft::WRL;
using namespace DX;

namespace adventures_of_orchi
{
	// This sample renderer instantiates a basic rendering pipeline.
	class GameRenderer
	{
	public:
		GameRenderer(const std::shared_ptr<DeviceResources>& deviceResources, CoreWindow ^ window);
		void CreateDeviceDependentResources();
		void CreateWindowSizeDependentResources();
		void ReleaseDeviceDependentResources();
		int Update(DX::StepTimer const& timer);
		void Render();
		void StartTracking();
		void TrackingUpdate(float positionX);
		void StopTracking();
		bool IsTracking() { return m_tracking; }

		void OnKeyDown(KeyEventArgs ^ args);
		void OnSizeChanged(WindowSizeChangedEventArgs ^ args);

		Grid grid;

		void DrawLeftMargin();
		void DrawRightMargin();

	private:
		// TODO: Move these to Sword.
		void ThrowSword(int nDirection);
		void UpdateSword();

		void Rotate(float radians);

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
		bool	m_loadingComplete;
		float	m_degreesPerSecond;
		bool	m_tracking;

		Stack * m_pCurrentStack;

		void RenderSpaces2D();
		void RenderSpaces3D();

		Player * m_pPlayer;
		Sword * m_pSword;

		float m_fWindowWidth;
		float m_fWindowHeight;
		
		void DrawSpriteIntersection();
		int m_nCollisionState;

		int m_nCollidedSpriteColumn;
		int m_nCollidedSpriteRow;

		bool m_bSpriteCollisionDetected;

		BroadCollisionStrategy * m_broadCollisionDetectionStrategy;
		NarrowCollisionStrategy * m_pNarrowCollisionDetectionStrategy;
		PortalCollisionStrategy * m_pPortalCollisionDetectionStrategy;

		list<Space *> * m_pCollided;
		void HighlightRegion(int column, int row, ComPtr<ID2D1SolidColorBrush> brush);
		void HighlightRegion(int * pLocation, ComPtr<ID2D1SolidColorBrush> brush);

		DWRITE_TEXT_RANGE m_textRange;

		World * m_pWorld;

#ifdef RENDER_DIAGNOSTICS
		vector<D2D1_RECT_F> m_collidedRects;
		vector<int> m_collidedRectStatuses;
#endif // RENDER_DIAGNOSTICS

		int m_nSwordDirection;
		LifePanel m_lifePanel;
		MapPanel m_mapPanel;
		ButtonsPanel m_buttonsPanel;
		PackPanel m_packPanel;
		InventoryPanel m_inventoryPanel;

		vector<InfoPanel *> * m_infoPanels;

		XBoxOneControllerView xboxController;
	};
}

