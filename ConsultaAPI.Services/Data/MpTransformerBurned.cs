using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class MpTransformerBurned
{
    public long Id { get; set; }

    public string? CodeSig { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Total { get; set; }

    public string? Fparent { get; set; }

    public string? NameRegion { get; set; }

    public string? NameZone { get; set; }

    public string? NameLocality { get; set; }

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }
}
