using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SimulationAsset
{
    public int CodeSim { get; set; }

    public string Uia { get; set; } = null!;

    public string CodeSig { get; set; } = null!;

    public float? Longitude { get; set; }

    public float? Latitude { get; set; }
}
