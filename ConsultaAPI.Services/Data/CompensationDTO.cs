using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CompensationDTO
{    
    public List<int?> Month { get; set; }

    public int? MonthUnit { get; set; }

    public int? Year { get; set; }

    public List<string>? Fparent { get; set; }

    public string? FparentUnit { get; set; }

    public string? CodeSig { get; set; }

    public float? Vcf { get; set; }

    public float? Vcd { get; set; }    

    public float? Longitude { get; set; }

    public float? Latitude { get; set; }
}
