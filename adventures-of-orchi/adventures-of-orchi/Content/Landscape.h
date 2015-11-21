#pragma once
#include "ScreenOrientation.h"

class Landscape : public ScreenOrientation
{
public:
	void Update(float2 fWindowDimensions);
	void Render(float2 fWindowDimensions);

protected:

private:
};
