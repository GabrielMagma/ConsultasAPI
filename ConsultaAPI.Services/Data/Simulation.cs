using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class Simulation
{
    public int CodeSim { get; set; }

    public int Year { get; set; }

    public int IdRegion { get; set; }

    public string? NameRegion { get; set; }

    public int CodeSimulationType { get; set; }

    public string Fparent { get; set; } = null!;

    public double Factor { get; set; }

    public float SaidiFparent { get; set; }

    public float SaifiFparent { get; set; }

    public float AvgDiu { get; set; }

    public float AvgFiu { get; set; }

    public float SaidiAnnual { get; set; }

    public float SaifiAnnual { get; set; }

    public string? Usuario { get; set; }

    public int TotalCodeSig { get; set; }

    public int TotalUsers { get; set; }

    public DateTime SimDate { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<SimulationHistory> SimulationHistories { get; set; } = new List<SimulationHistory>();
}
