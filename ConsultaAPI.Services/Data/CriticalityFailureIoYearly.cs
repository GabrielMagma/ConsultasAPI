using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityFailureIoYearly
{
    public long Id { get; set; }

    public int? Year { get; set; }

    public string? TypeAsset { get; set; }

    public string? CodeSig { get; set; }

    public long? FailureCount { get; set; }
}
