﻿using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class PerceptionSaifiAnnual
{
    public int Year { get; set; }

    public int Month { get; set; }

    public float Saifi { get; set; }
}