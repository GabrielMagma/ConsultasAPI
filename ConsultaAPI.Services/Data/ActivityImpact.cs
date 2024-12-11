using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityImpact
{
    public long Id { get; set; }

    public string Impact { get; set; } = null!;
}
