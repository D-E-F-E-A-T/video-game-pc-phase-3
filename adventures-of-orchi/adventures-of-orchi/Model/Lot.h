#pragma once
#include "Subdivision.h"
#include "..\Grid.h"

class Lot : public Subdivision
{
public:
	void Render(
		float lpfScreenDimensions[2],
		Grid * lpGrid,
		const shared_ptr<DeviceResources>& deviceResources);

protected:

private:
};
