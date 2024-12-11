using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class Forecast3
{
    public DateTime? Date { get; set; }

    public double? Saidi { get; set; }

    public string? Periodo { get; set; }
}
