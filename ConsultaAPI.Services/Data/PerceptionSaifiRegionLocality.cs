﻿using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class PerceptionSaifiRegionLocality
{
    public int Year { get; set; }

    public int Month { get; set; }

    public long IdRegion { get; set; }

    public string NameRegion { get; set; } = null!;

    public long IdLocality { get; set; }

    public string NameLocality { get; set; } = null!;

    public string CodeSig { get; set; } = null!;

    public string? Fparent { get; set; }

    public string? Group015 { get; set; }

    public string? Codetaxo { get; set; }

    public string Uia { get; set; } = null!;

    public float Saifi { get; set; }
}