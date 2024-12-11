using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityConsequencePrincipal
{
    public long Id { get; set; }

    public string? Consequence { get; set; }

    public string? Concept { get; set; }

    public double Value { get; set; }
}
