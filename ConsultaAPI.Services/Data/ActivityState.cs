using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityState
{
    public long Id { get; set; }

    public string State { get; set; } = null!;
}
