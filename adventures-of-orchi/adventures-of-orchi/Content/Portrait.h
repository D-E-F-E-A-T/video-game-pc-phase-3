#pragma once
#include "ScreenOrientation.h"

class Portrait : public ScreenOrientation
{
public:
	void Update(float2 fWindowDimensions);
	void Render(float2 fWindowDimensions);

protected:

private:
};
