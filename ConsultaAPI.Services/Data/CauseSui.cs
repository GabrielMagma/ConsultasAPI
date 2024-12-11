using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CauseSui
{
    public long Code { get; set; }

    public string DescriptionCause { get; set; } = null!;

    public string? State { get; set; }
}
