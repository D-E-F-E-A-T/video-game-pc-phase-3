#pragma once
#include "pch.h"
#include "Landscape.h"
#include "Portrait.h"
#include "ScreenOrientation.h"

class OrientationRenderer
{
public:
	OrientationRenderer()
	{
		m_lpOrientations = new ScreenOrientation[2];
		m_lpOrientations[0] = new Landscape();
		m_lpOrientations[1] = new Portrait();

	}
	~OrientationRenderer();

	void Update();
	void Render();

protected:
	ScreenOrientation * m_lpOrientations;

private:
};
