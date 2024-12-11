using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class Compensation
{
    public int Id { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public string? Fparent { get; set; }

    public string? CodeSig { get; set; }

    public string? QualityGroup { get; set; }

    public string? TensionLevel { get; set; }

    public string? Nui { get; set; }

    public float? Vcf { get; set; }

    public float? Vcd { get; set; }

    public float? Vc { get; set; }

    public float? Longitude { get; set; }

    public float? Latitude { get; set; }
}
