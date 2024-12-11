using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityConsequenceParameter
{
    public long Id { get; set; }

    public string? Parameter { get; set; }

    public string? Concept { get; set; }

    public double? Value { get; set; }
}
