using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityType
{
    public long Id { get; set; }

    public string Type { get; set; } = null!;

    public bool? IsActive { get; set; }
}
