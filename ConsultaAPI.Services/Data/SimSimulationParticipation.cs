using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SimSimulationParticipation
{
    public int? CodeSim { get; set; }

    public string? EventCode { get; set; }

    public float? TotalDium { get; set; }

    public float? ParticipationPercentage { get; set; }

    public int? Exclusion { get; set; }
}
