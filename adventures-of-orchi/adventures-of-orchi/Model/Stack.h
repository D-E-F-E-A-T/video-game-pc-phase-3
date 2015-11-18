#pragma once
#include "Layer.h"

class Stack
{
public:
	Stack();

	// Keep the player layer the same.
	void Add(int depth, Space * space);
	Layer * Get(int depth);
	size_t GetNumLayers() { return m_layers.size(); }
	void Clear();


protected:

private:
	map<int, Layer *> m_layers;
};
