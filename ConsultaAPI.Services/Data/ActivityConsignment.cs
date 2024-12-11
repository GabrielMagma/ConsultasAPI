using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityConsignment
{
    public long Id { get; set; }

    public long ActivityId { get; set; }

    public string ConsignmentNumber { get; set; } = null!;
}
