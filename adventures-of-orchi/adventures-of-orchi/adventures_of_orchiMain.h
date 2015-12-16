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

#include "Common\StepTimer.h"
#include "Common\DeviceResources.h"
#include "Content\SampleFpsTextRenderer.h"
#include "Content\GameRenderer.h"

using namespace Windows::UI::ViewManagement;

// Renders Direct2D and 3D content on the screen.
namespace adventures_of_orchi
{
	class adventures_of_orchiMain : public IDeviceNotify
	{
	public:
		adventures_of_orchiMain(
			const std::shared_ptr<DeviceResources>& deviceResources, CoreWindow ^ window);
		~adventures_of_orchiMain();
		void CreateWindowSizeDependentResources();
		//void StartTracking() 
		//{ 
		//	m_gameRenderer->StartTracking();

		//}

		void OnPointerPressed(ResolutionScale resolutionScale, float fX, float fY)
		{
			m_gameRenderer->OnPointerPressed(resolutionScale, fX, fY);
		}

		void OnPointerReleased()
		{
			m_gameRenderer->OnPointerReleased();
		}

		//void TrackingUpdate(float positionX) { m_pointerLocationX = positionX; }
		//void StopTracking() 
		//{ 
		//	m_gameRenderer->StopTracking();
		//}
		//bool IsTracking() 
		//{ 
		//	return m_gameRenderer->IsTracking(); 
		//}
		void StartRenderLoop();
		void StopRenderLoop();
		Concurrency::critical_section& GetCriticalSection() { return m_criticalSection; }

		// IDeviceNotify
		virtual void OnDeviceLost();
		virtual void OnDeviceRestored();
		void OnKeyDown(Windows::UI::Core::KeyEventArgs ^ args);
		void OnSizeChanged(
			Windows::UI::Core::WindowSizeChangedEventArgs ^ args,
			UserInteractionMode uiMode);

		void SetUserInteractionMode(UserInteractionMode uiMode);

	private:
		void ProcessInput();
		int Update();
		bool Render();

		// Cached pointer to device resources.
		std::shared_ptr<DeviceResources> m_deviceResources;

		// TODO: Replace with your own content renderers.
		std::unique_ptr<SampleFpsTextRenderer> m_fpsTextRenderer;
		std::unique_ptr<GameRenderer> m_gameRenderer;

		Windows::Foundation::IAsyncAction^ m_renderLoopWorker;
		Concurrency::critical_section m_criticalSection;

		// Rendering loop timer.
		DX::StepTimer m_timer;

		// Track current input pointer position.
		float m_pointerLocationX;
	};
}