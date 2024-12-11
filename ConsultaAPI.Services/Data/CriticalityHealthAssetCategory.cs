using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityHealthAssetCategory
{
    public int? Criticality { get; set; }

    public double? PercentLifeStart { get; set; }

    public double? PercentLifeEnd { get; set; }

    public string? Mc { get; set; }

    public long? McNum { get; set; }
}
