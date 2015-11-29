#include "pch.h"
#include "RightMargin.h"

RightMargin::RightMargin()
{

}

void RightMargin::Draw(
	ComPtr<ID2D1DeviceContext1> context,
	ID2D1SolidColorBrush * brush,
	D2D1_RECT_F rect)
{
	context->FillRectangle(
		rect,
		brush);
}