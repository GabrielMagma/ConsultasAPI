using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityCategory
{
    public long IdTb { get; set; }

    public int? LowerBound { get; set; }

    public int? UpperBound { get; set; }

    public string? Criticality { get; set; }

    public int? CriticalityNum { get; set; }
}
