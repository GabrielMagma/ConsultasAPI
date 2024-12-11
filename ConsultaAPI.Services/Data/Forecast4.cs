using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class Forecast4
{
    public DateTime? Ds { get; set; }

    public double? Yhat { get; set; }

    public double? Trend { get; set; }

    public double? YhatLower { get; set; }

    public double? YhatUpper { get; set; }

    public string? Periodo { get; set; }
}
