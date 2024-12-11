﻿using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class PerceptionDiuMonth
{
    public int Year { get; set; }

    public int Month { get; set; }

    public string CodeSig { get; set; } = null!;

    public string? Fparent { get; set; }

    public string? Group015 { get; set; }

    public string? Codetaxo { get; set; }

    public string? Uia { get; set; }

    public int? CauseSui { get; set; }

    public int? CauseCreg { get; set; }

    public float Dium { get; set; }

    public string EventCode { get; set; } = null!;
}