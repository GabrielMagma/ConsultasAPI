using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SimDiu
{
    public int Year { get; set; }

    public int Month { get; set; }

    public int? IdRegion { get; set; }

    public string? NameRegion { get; set; }

    public int? IdLocality { get; set; }

    public string? NameLocatity { get; set; }

    public string CodeSig { get; set; } = null!;

    public string? Fparent { get; set; }

    public string? Group015 { get; set; }

    public string? Codetaxo { get; set; }

    public string? Uia { get; set; }

    public int? CountUser { get; set; }

    public float? Diu { get; set; }

    public int? CategoryDiu { get; set; }

    public int? CodeSim { get; set; }

    public virtual Simulation? CodeSimNavigation { get; set; }
}
