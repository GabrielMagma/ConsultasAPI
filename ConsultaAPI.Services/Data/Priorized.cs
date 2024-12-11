using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class Priorized
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public string? Fparent { get; set; }

    public string? CodeSig { get; set; }

    public string? Codetaxo { get; set; }

    public string? Group015 { get; set; }

    public double? Category3 { get; set; }

    public double? Category6 { get; set; }

    public double? Category9 { get; set; }

    public double? Category12 { get; set; }

    public double? Diu { get; set; }

    public double? Fiu { get; set; }

    public string? Category { get; set; }

    public string? Consequence { get; set; }

    public string? Criticality { get; set; }

    public int? FailureCount { get; set; }
}
