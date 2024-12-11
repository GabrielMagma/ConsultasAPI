using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CausalSimulationType
{
    public int Id { get; set; }

    public int SimulationTypeCode { get; set; }

    public int CauseCreg { get; set; }
}
