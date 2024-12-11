using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class PerceptionFiuNiu
{
    public int Year { get; set; }

    public int Month { get; set; }

    public string? Uia { get; set; }

    public string Niu { get; set; } = null!;

    public float Fiu { get; set; }
}
