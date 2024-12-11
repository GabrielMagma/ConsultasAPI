using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityFailureIoNoexc
{
    public long Id { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public string? TypeAsset { get; set; }

    public string CodeSig { get; set; } = null!;

    public string? Codetaxo { get; set; }

    public string? Fparent { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public long? FailureCount { get; set; }
}
