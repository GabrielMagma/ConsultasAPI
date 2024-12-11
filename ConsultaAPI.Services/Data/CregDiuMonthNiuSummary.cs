using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CregDiuMonthNiuSummary
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public string? CodeSig { get; set; }

    public string? Uia { get; set; }

    public string? Niu { get; set; }

    public float? DiumTotal { get; set; }
}
