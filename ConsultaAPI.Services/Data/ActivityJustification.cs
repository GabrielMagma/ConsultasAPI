using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityJustification
{
    public long Id { get; set; }

    public string Justify { get; set; } = null!;
}
