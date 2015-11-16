#pragma once
#include "pch.h"
#include "Renderable3D.h"

class Figure : public Renderable3D
{
public:
	virtual void Render(
		ComPtr<ID3D11RenderTargetView> renderTargetView,
		float2 fWindowDimensions,
		float2 fScaleDimensions,
		float dpi)
	{
	}

protected:

private:
};
