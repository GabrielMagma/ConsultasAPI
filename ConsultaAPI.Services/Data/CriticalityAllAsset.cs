using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityAllAsset
{
    public long Id { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string? TypeAsset { get; set; }

    public string? CodeSig { get; set; }

    public string? Codetaxo { get; set; }

    public string? Fparent { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public int? FailureCount { get; set; }

    public string? Group015 { get; set; }

    public string? Uccap14 { get; set; }

    public string? Poblation { get; set; }

    public int? IntervalId { get; set; }

    public int? NumCategory { get; set; }

    public string? Category { get; set; }

    public string? Consequence { get; set; }

    public int? CriticalityCount { get; set; }

    public int? CriticalityNum { get; set; }

    public string? Criticality { get; set; }
}
