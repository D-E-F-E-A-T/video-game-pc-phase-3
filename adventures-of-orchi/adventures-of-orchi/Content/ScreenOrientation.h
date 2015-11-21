#pragma once
#include "pch.h"

class ScreenOrientation
{
public:
	virtual void Update(float2 fWindowDimensions) = 0;
	virtual void Render(float2 fWindowDimensions) = 0;

protected:
	
private:
};
