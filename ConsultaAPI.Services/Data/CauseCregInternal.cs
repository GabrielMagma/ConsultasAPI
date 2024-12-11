using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

/// <summary>
/// Causas internas  y Causas Creg
/// </summary>
public partial class CauseCregInternal
{
    public long Id { get; set; }

    public int CregCause { get; set; }

    public int? InternalCause { get; set; }

    public string? DescriptionCause { get; set; }

    public string? Clasification { get; set; }

    public int Exclusion { get; set; }
}
