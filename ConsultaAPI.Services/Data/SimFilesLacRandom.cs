using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SimFilesLacRandom
{
    public long? Id { get; set; }

    public int? CodeSim { get; set; }

    public string? EventCode { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Uia { get; set; }

    public int? ElementType { get; set; }

    public int? EventCause { get; set; }

    public string? EventContinues { get; set; }

    public int? EventExcluidZin { get; set; }

    public int? AffectsConnection { get; set; }

    public int? LightingUsers { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string? Files { get; set; }

    public DateOnly? FilesDate { get; set; }

    public int? State { get; set; }

    public string? FileCode { get; set; }

    public virtual Simulation? CodeSimNavigation { get; set; }
}
