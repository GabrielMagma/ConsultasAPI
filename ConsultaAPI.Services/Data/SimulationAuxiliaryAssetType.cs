using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SimulationAuxiliaryAssetType
{
    public int CodeSim { get; set; }

    public int IdAuxiliaryAssetType { get; set; }

    public float? Longitude { get; set; }

    public float? Latitude { get; set; }
}
