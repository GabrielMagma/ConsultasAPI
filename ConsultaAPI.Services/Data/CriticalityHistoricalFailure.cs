using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityHistoricalFailure
{
    public long Id { get; set; }

    public DateOnly DateIo { get; set; }

    public string? CodeSig { get; set; }

    public string? TypeAsset { get; set; }

    public string? Fparent { get; set; }

    public double? MinInterruption { get; set; }

    public int? Users { get; set; }

    public int? FailureCount { get; set; }

    public int? CregCause { get; set; }

    public string? DescriptionCreg { get; set; }

    public int? Cause { get; set; }

    public string? DescriptionCause { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public string? Codetaxo { get; set; }
}
