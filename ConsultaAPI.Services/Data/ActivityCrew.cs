using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityCrew
{
    public long Id { get; set; }

    public string Crew { get; set; } = null!;
}
