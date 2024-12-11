using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class Forecast1
{
    public DateTime? Date { get; set; }

    public string? Group { get; set; }

    public double? Value { get; set; }

    public string? Periodo { get; set; }
}
