using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

/// <summary>
/// CAUSAS SUI Y CAUSAS CREG
/// </summary>
public partial class CauseCregSui
{
    public long Id { get; set; }

    public int CregCause { get; set; }

    public int? SuiCause { get; set; }

    public string? DescriptionCause { get; set; }

    public string? Clasification { get; set; }

    public int Exclusion { get; set; }
}
