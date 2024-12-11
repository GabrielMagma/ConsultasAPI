using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityFailureIoInterval
{
    public int Year { get; set; }

    public string? TypeAsset { get; set; }

    public long? IntervalId { get; set; }

    public double? LowerBound { get; set; }

    public double? UpperBound { get; set; }

    public int? NumCategory { get; set; }

    public string? Category { get; set; }
}
