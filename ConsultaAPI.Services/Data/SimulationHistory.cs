using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SimulationHistory
{
    public int Id { get; set; }

    public int CodeSim { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? Timestamp { get; set; }

    public virtual Simulation CodeSimNavigation { get; set; } = null!;
}
