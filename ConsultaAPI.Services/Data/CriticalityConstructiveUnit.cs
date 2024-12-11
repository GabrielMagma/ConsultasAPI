using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityConstructiveUnit
{
    public long IdTb { get; set; }

    public string Uccap14 { get; set; } = null!;

    public int TensionLevel { get; set; }

    public int LifeYears { get; set; }

    public int? Year { get; set; }
}
