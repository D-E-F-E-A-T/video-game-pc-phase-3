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
#include "TouchScreenControllerView.h"
#include "..\Common\DeviceResources.h"
#include "..\Utils.h"

void TouchScreenControllerView::RenderButtonTouchControls(
	float2 fWindowBounds,
	bool bXButtonPressed,
	bool bYButtonPressed,
	bool bAButtonPressed,
	bool bBButtonPressed,
	const std::shared_ptr<DeviceResources>& deviceResources)
{
	float fX =
		(
			(fWindowBounds.x * 0.99f) -
			(fWindowBounds.x * (1.f - RIGHT_MARGIN_RATIO + 0.01f))
			) / 2.0f;

	fX += fWindowBounds.x * (1.f - RIGHT_MARGIN_RATIO + 0.01f);

	float fY =
		(fWindowBounds.y * 0.95f -
			fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT) / 2.0f;

	fY += fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT;


	D2D1_ELLIPSE ellipseX
	{
		D2D1_POINT_2F
	{
		fX - fWindowBounds.x * BUTTON_OFFSET_RATIO,
		fY
	},
		fWindowBounds.x * BUTTON_SIZE_RATIO,
		fWindowBounds.x * BUTTON_SIZE_RATIO
	};

	if (bXButtonPressed == false)
	{
		deviceResources->GetD2DDeviceContext()->DrawEllipse(
			ellipseX,
			deviceResources->m_mapBrushes["blue"]);
	}
	else
	{
		deviceResources->GetD2DDeviceContext()->FillEllipse(
			ellipseX,
			deviceResources->m_mapBrushes["blue"]);
	}


	D2D1_ELLIPSE ellipseB
	{
		D2D1_POINT_2F
	{
		fX + fWindowBounds.x * BUTTON_OFFSET_RATIO,
		fY
	},
		fWindowBounds.x * BUTTON_SIZE_RATIO,
		fWindowBounds.x * BUTTON_SIZE_RATIO
	};

	if (bBButtonPressed == false)
	{
		deviceResources->GetD2DDeviceContext()->DrawEllipse(
			ellipseB,
			deviceResources->m_mapBrushes["red"]);
	}
	else
	{
		deviceResources->GetD2DDeviceContext()->FillEllipse(
			ellipseB,
			deviceResources->m_mapBrushes["red"]);
	}

	D2D1_ELLIPSE ellipseA
	{
		D2D1_POINT_2F
	{
		fX,
		fY + fWindowBounds.x * BUTTON_OFFSET_RATIO,
	},
		fWindowBounds.x * BUTTON_SIZE_RATIO,
		fWindowBounds.x * BUTTON_SIZE_RATIO
	};

	if (bAButtonPressed == false)
	{
		deviceResources->GetD2DDeviceContext()->DrawEllipse(
			ellipseA,
			deviceResources->m_mapBrushes["green"]);
	}
	else
	{
		deviceResources->GetD2DDeviceContext()->FillEllipse(
			ellipseA,
			deviceResources->m_mapBrushes["green"]);
	}

	D2D1_ELLIPSE ellipseY
	{
		D2D1_POINT_2F
	{
		fX,
		fY - fWindowBounds.x * BUTTON_OFFSET_RATIO,
	},
		fWindowBounds.x * BUTTON_SIZE_RATIO,
		fWindowBounds.x * BUTTON_SIZE_RATIO
	};

	if (bYButtonPressed == false)
	{
		deviceResources->GetD2DDeviceContext()->DrawEllipse(
			ellipseY,
			deviceResources->m_mapBrushes["yellow"]);
	}
	else
	{
		deviceResources->GetD2DDeviceContext()->FillEllipse(
			ellipseY,
			deviceResources->m_mapBrushes["yellow"]);
	}
}

void TouchScreenControllerView::RenderDirectionalTouchControls(
	float2 fWindowBounds,
	bool bNorthButtonPressed,
	bool bEastButtonPressed,
	bool bSouthButtonPressed,
	bool bWestButtonPressed,
	const std::shared_ptr<DeviceResources>& deviceResources)
{
	float boundsLeft = fWindowBounds.x * 0.01f;
	float boundsTop = fWindowBounds.y * 0.75f;
	float boundsRight = fWindowBounds.x * (LEFT_MARGIN_RATIO - 0.01f);
	float boundsBottom = fWindowBounds.y * 0.95f;


	float fMidpoint = (boundsRight - boundsLeft) / 2.0f;

	float fX = boundsLeft + fMidpoint;

	float fY =
		(fWindowBounds.y * 0.95f -
			fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT) / 2.0f;

	fY += fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT;

	D2D1_ELLIPSE ellipseWest
	{
		D2D1_POINT_2F
	{
		fX - (fWindowBounds.x * BUTTON_OFFSET_RATIO),
		fY
	},
		fWindowBounds.x * BUTTON_SIZE_RATIO,
		fWindowBounds.x * BUTTON_SIZE_RATIO
	};

	if (bWestButtonPressed == false)
	{
		deviceResources->GetD2DDeviceContext()->DrawEllipse(
			ellipseWest,
			deviceResources->m_mapBrushes["white"]);
	}
	else
	{
		deviceResources->GetD2DDeviceContext()->FillEllipse(
			ellipseWest,
			deviceResources->m_mapBrushes["white"]);
	}


	D2D1_ELLIPSE ellipseEast
	{
		D2D1_POINT_2F
	{
		fX + fWindowBounds.x * BUTTON_OFFSET_RATIO,
		fY
	},
		fWindowBounds.x * BUTTON_SIZE_RATIO,
		fWindowBounds.x * BUTTON_SIZE_RATIO
	};

	if (bEastButtonPressed == false)
	{
		deviceResources->GetD2DDeviceContext()->DrawEllipse(
			ellipseEast,
			deviceResources->m_mapBrushes["white"]);
	}
	else
	{
		deviceResources->GetD2DDeviceContext()->FillEllipse(
			ellipseEast,
			deviceResources->m_mapBrushes["white"]);
	}

	D2D1_ELLIPSE ellipseSouth
	{
		D2D1_POINT_2F
	{
		fX,
		fY + fWindowBounds.x * BUTTON_OFFSET_RATIO,
	},
		fWindowBounds.x * BUTTON_SIZE_RATIO,
		fWindowBounds.x * BUTTON_SIZE_RATIO
	};

	if (bSouthButtonPressed == false)
	{
		deviceResources->GetD2DDeviceContext()->DrawEllipse(
			ellipseSouth,
			deviceResources->m_mapBrushes["white"]);
	}
	else
	{
		deviceResources->GetD2DDeviceContext()->FillEllipse(
			ellipseSouth,
			deviceResources->m_mapBrushes["white"]);
	}

	D2D1_ELLIPSE ellipseNorth
	{
		D2D1_POINT_2F
	{
		fX,
		fY - fWindowBounds.x * BUTTON_OFFSET_RATIO,
	},
		fWindowBounds.x * BUTTON_SIZE_RATIO,
		fWindowBounds.x * BUTTON_SIZE_RATIO
	};

	if (bNorthButtonPressed == false)
	{
		deviceResources->GetD2DDeviceContext()->DrawEllipse(
			ellipseNorth,
			deviceResources->m_mapBrushes["white"]);
	}
	else
	{
		deviceResources->GetD2DDeviceContext()->FillEllipse(
			ellipseNorth,
			deviceResources->m_mapBrushes["white"]);
	}
}

bool TouchScreenControllerView::CheckNorthButton(
	float2 fWindowBounds,
	float2 fHitPoint)
{
	bool retVal = false;

	float boundsLeft = fWindowBounds.x * 0.01f;
	float boundsTop = fWindowBounds.y * 0.75f;
	float boundsRight = fWindowBounds.x * (LEFT_MARGIN_RATIO - 0.01f);
	float boundsBottom = fWindowBounds.y * 0.95f;

	float fMidpoint = (boundsRight - boundsLeft) / 2.0f;

	float fX = boundsLeft + fMidpoint;

	float fY =
		(fWindowBounds.y * 0.95f -
			fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT) / 2.0f;

	fY += fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT;


	float fButtonRadius = fWindowBounds.x * BUTTON_SIZE_RATIO;
	float2 fButtonCenter = float2{ fX, fY - fWindowBounds.x * BUTTON_OFFSET_RATIO };

	float fOffset = Utils::CalculateDistance(fButtonCenter, fHitPoint);

	if (fOffset <= fButtonRadius)
		retVal = true;

	return retVal;
}

bool TouchScreenControllerView::CheckEastButton(
	float2 fWindowBounds,
	float2 fHitPoint)
{
	bool retVal = false;

	float boundsLeft = fWindowBounds.x * 0.01f;
	float boundsTop = fWindowBounds.y * 0.75f;
	float boundsRight = fWindowBounds.x * (LEFT_MARGIN_RATIO - 0.01f);
	float boundsBottom = fWindowBounds.y * 0.95f;

	float fMidpoint = (boundsRight - boundsLeft) / 2.0f;

	float fX = boundsLeft + fMidpoint;

	float fY =
		(fWindowBounds.y * 0.95f -
			fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT) / 2.0f;

	fY += fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT;


	float fButtonRadius = fWindowBounds.x * BUTTON_SIZE_RATIO;
	float2 fButtonCenter = float2{ fX + fWindowBounds.x * BUTTON_OFFSET_RATIO, fY };

	float fOffset = Utils::CalculateDistance(fButtonCenter, fHitPoint);

	if (fOffset <= fButtonRadius)
		retVal = true;

	return retVal;
}


bool TouchScreenControllerView::CheckSouthButton(
	float2 fWindowBounds,
	float2 fHitPoint)
{
	bool retVal = false;

	float boundsLeft = fWindowBounds.x * 0.01f;
	float boundsTop = fWindowBounds.y * 0.75f;
	float boundsRight = fWindowBounds.x * (LEFT_MARGIN_RATIO - 0.01f);
	float boundsBottom = fWindowBounds.y * 0.95f;

	float fMidpoint = (boundsRight - boundsLeft) / 2.0f;

	float fX = boundsLeft + fMidpoint;

	float fY =
		(fWindowBounds.y * 0.95f -
			fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT) / 2.0f;

	fY += fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT;


	float fButtonRadius = fWindowBounds.x * BUTTON_SIZE_RATIO;
	float2 fButtonCenter = float2{ fX, fY + fWindowBounds.x * BUTTON_OFFSET_RATIO };

	float fOffset = Utils::CalculateDistance(fButtonCenter, fHitPoint);

	if (fOffset <= fButtonRadius)
		retVal = true;

	return retVal;
}

bool TouchScreenControllerView::CheckWestButton(
	float2 fWindowBounds,
	float2 fHitPoint)
{
	bool retVal = false;

	float boundsLeft = fWindowBounds.x * 0.01f;
	float boundsTop = fWindowBounds.y * 0.75f;
	float boundsRight = fWindowBounds.x * (LEFT_MARGIN_RATIO - 0.01f);
	float boundsBottom = fWindowBounds.y * 0.95f;

	float fMidpoint = (boundsRight - boundsLeft) / 2.0f;

	float fX = boundsLeft + fMidpoint;

	float fY =
		(fWindowBounds.y * 0.95f -
			fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT) / 2.0f;

	fY += fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT;


	float fButtonRadius = fWindowBounds.x * BUTTON_SIZE_RATIO;
	float2 fButtonCenter = float2{ fX - (fWindowBounds.x * BUTTON_OFFSET_RATIO), fY };

	float fOffset = Utils::CalculateDistance(fButtonCenter, fHitPoint);

	if (fOffset <= fButtonRadius)
		retVal = true;

	return retVal;
}

bool TouchScreenControllerView::CheckYButton(
	float2 fWindowBounds,
	float2 fHitPoint)
{
	bool retVal = false;

	float fX =
		(
			(fWindowBounds.x * 0.99f) -
			(fWindowBounds.x * (1.f - RIGHT_MARGIN_RATIO + 0.01f))
			) / 2.0f;

	fX += fWindowBounds.x * (1.f - RIGHT_MARGIN_RATIO + 0.01f);

	float fY =
		(fWindowBounds.y * 0.95f -
			fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT) / 2.0f;

	fY += fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT;


	float fButtonRadius = fWindowBounds.x * BUTTON_SIZE_RATIO;
	float2 fButtonCenter = float2{ fX, fY - fWindowBounds.x * BUTTON_OFFSET_RATIO };

	float fOffset = Utils::CalculateDistance(fButtonCenter, fHitPoint);

	if (fOffset <= fButtonRadius)
		retVal = true;

	return retVal;
}

bool TouchScreenControllerView::CheckBButton(
	float2 fWindowBounds,
	float2 fHitPoint)
{
	bool retVal = false;

	float fX =
		(
			(fWindowBounds.x * 0.99f) -
			(fWindowBounds.x * (1.f - RIGHT_MARGIN_RATIO + 0.01f))
			) / 2.0f;

	fX += fWindowBounds.x * (1.f - RIGHT_MARGIN_RATIO + 0.01f);

	float fY =
		(fWindowBounds.y * 0.95f -
			fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT) / 2.0f;

	fY += fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT;


	float fButtonRadius = fWindowBounds.x * BUTTON_SIZE_RATIO;
	float2 fButtonCenter = float2{ fX + fWindowBounds.x * BUTTON_OFFSET_RATIO, fY };

	float fOffset = Utils::CalculateDistance(fButtonCenter, fHitPoint);

	if (fOffset <= fButtonRadius)
		retVal = true;

	return retVal;
}



bool TouchScreenControllerView::CheckAButton(
	float2 fWindowBounds,
	float2 fHitPoint)
{
	bool retVal = false;

	float fX =
		(
			(fWindowBounds.x * 0.99f) -
			(fWindowBounds.x * (1.f - RIGHT_MARGIN_RATIO + 0.01f))
			) / 2.0f;

	fX += fWindowBounds.x * (1.f - RIGHT_MARGIN_RATIO + 0.01f);

	float fY =
		(fWindowBounds.y * 0.95f -
			fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT) / 2.0f;

	fY += fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT;


	float fButtonRadius = fWindowBounds.x * BUTTON_SIZE_RATIO;
	float2 fButtonCenter = float2{ fX, fY + fWindowBounds.x * BUTTON_OFFSET_RATIO };

	float fOffset = Utils::CalculateDistance(fButtonCenter, fHitPoint);

	if (fOffset <= fButtonRadius)
		retVal = true;

	return retVal;
}

bool TouchScreenControllerView::CheckXButton(
	float2 fWindowBounds,
	float2 fHitPoint)
{
	bool retVal = false;

	float fX =
		(
			(fWindowBounds.x * 0.99f) -
			(fWindowBounds.x * (1.f - RIGHT_MARGIN_RATIO + 0.01f))
			) / 2.0f;

	fX += fWindowBounds.x * (1.f - RIGHT_MARGIN_RATIO + 0.01f);

	float fY =
		(fWindowBounds.y * 0.95f -
			fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT) / 2.0f;

	fY += fWindowBounds.y * TOUCH_CONTROLS_MIDPOINT_HEIGHT;


	float fButtonRadius = fWindowBounds.x * BUTTON_SIZE_RATIO;
	float2 fButtonCenter = float2{ fX - fWindowBounds.x * BUTTON_OFFSET_RATIO, fY };

	float fOffset = Utils::CalculateDistance(fButtonCenter, fHitPoint);

	if (fOffset <= fButtonRadius)
		retVal = true;

	return retVal;
}

