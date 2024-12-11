using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityLac
{
    public long Id { get; set; }

    public long ActivityId { get; set; }

    public string EventCode { get; set; } = null!;
}
