using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CregDiuMonthSummary
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public string? CodeSig { get; set; }

    public string? Uia { get; set; }

    public float? TotalDium { get; set; }
}
