using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SimSaidiFparent
{
    public int Year { get; set; }

    public float? Saidi { get; set; }

    public int? CodeSim { get; set; }

    public virtual Simulation? CodeSimNavigation { get; set; }
}
