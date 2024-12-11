using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SimCuttingElement
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
