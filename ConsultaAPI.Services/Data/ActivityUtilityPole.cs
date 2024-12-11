using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityUtilityPole
{
    public long Id { get; set; }

    public long ActivityId { get; set; }

    public string PaintingCode { get; set; } = null!;
}
