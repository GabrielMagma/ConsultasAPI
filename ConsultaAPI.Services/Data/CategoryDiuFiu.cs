using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CategoryDiuFiu
{
    public int? CategoryNumber { get; set; }

    public string? Description { get; set; }

    public int? InitialLimit { get; set; }

    public int? EndLimit { get; set; }
}
