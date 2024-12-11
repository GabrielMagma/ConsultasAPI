using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityWorkOrder
{
    public long Id { get; set; }

    public long ActivityId { get; set; }

    public string OrderNumber { get; set; } = null!;
}
