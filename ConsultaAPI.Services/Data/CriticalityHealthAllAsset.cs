using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityHealthAllAsset
{
    public long Id { get; set; }

    public string? TypeAsset { get; set; }

    public string? CodeSig { get; set; }

    public string? Codetaxo { get; set; }

    public string? Fparent { get; set; }

    public string? Poblation { get; set; }

    public string? Group015 { get; set; }

    public DateOnly? DateInst { get; set; }

    public int? LifeYears { get; set; }

    public string? Uccap14 { get; set; }

    public string? Criticality { get; set; }

    public int? CriticalityNum { get; set; }

    public string? Mc { get; set; }

    public int? McNum { get; set; }

    public string? Obsolescence { get; set; }

    public int? ObsolescenceYear { get; set; }

    public int? ConstructiveUnit { get; set; }

    public double? PercentLife { get; set; }
}
