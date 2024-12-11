using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CregDiuFiuMonthPercent
{
    public int Year { get; set; }

    public int Month { get; set; }

    public string CodeSig { get; set; } = null!;

    public string? Fparent { get; set; }

    public string? Uia { get; set; }

    public float? CurrentDium { get; set; }

    public float? CurrentFium { get; set; }

    public float? PreviousFium { get; set; }

    public float? PreviousDium { get; set; }

    public float? DiumPercentage { get; set; }

    public float? FiumPercentage { get; set; }
}
