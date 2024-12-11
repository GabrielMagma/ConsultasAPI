using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SimSaifiFparent
{
    public int Year { get; set; }

    public float? Saifi { get; set; }

    public int? CodeSim { get; set; }

    public virtual Simulation? CodeSimNavigation { get; set; }
}
