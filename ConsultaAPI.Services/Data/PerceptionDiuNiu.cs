using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class PerceptionDiuNiu
{
    public int Year { get; set; }

    public int Month { get; set; }

    public string? Uia { get; set; }

    public string Niu { get; set; } = null!;

    public float Diu { get; set; }
}
