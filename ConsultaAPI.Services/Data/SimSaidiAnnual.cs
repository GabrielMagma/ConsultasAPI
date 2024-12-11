using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SimSaidiAnnual
{
    public int Year { get; set; }

    public int Month { get; set; }

    public float? Saidi { get; set; }

    public int? CodeSim { get; set; }

    public virtual Simulation? CodeSimNavigation { get; set; }
}
