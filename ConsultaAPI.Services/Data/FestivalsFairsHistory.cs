using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class FestivalsFairsHistory
{
    public string? Locality { get; set; }

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }

    public int? Year { get; set; }

    public DateOnly? InitialDate { get; set; }

    public DateOnly? FinalDate { get; set; }

    public string? Description { get; set; }
}
