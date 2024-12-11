using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityPriority
{
    public long Id { get; set; }

    public string Priority { get; set; } = null!;
}
