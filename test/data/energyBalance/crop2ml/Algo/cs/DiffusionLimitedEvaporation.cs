if (deficitOnTopLayers / 1000 <= 0)
	diffusionLimitedEvaporation = 8.3 * 1000;
else
{
	if (deficitOnTopLayers / 1000 < 25)
		diffusionLimitedEvaporation = (2 * soilDiffusionConstant * soilDiffusionConstant / (deficitOnTopLayers / 1000)) * 1000;
	else
		diffusionLimitedEvaporation = 0;
}
