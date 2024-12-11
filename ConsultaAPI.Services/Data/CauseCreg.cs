using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

/// <summary>
/// Causales Creg
/// </summary>
public partial class CauseCreg
{
    public long Id { get; set; }

    public int CregCause { get; set; }

    public string DescriptionCreg { get; set; } = null!;

    public int Exclusion { get; set; }

    public int? Maintenance { get; set; }
}
