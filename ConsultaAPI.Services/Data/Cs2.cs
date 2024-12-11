using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class Cs2
{
    public int Year { get; set; }

    public int Month { get; set; }

    public string Niu { get; set; } = null!;

    public float Diu { get; set; }

    public float Dium { get; set; }

    public float? Fiu { get; set; }

    public float Fium { get; set; }

    public int IdMercado { get; set; }

    public int CregCause { get; set; }

    public float Interruption { get; set; }

    public float Duration { get; set; }
}
