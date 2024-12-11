using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SimSimulationParticipationStatistic
{
    public int? CodeSim { get; set; }

    public float? AverageParticipationPercentage { get; set; }

    public float? MedianParticipationPercentage { get; set; }
}
