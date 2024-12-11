using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class AdminRole
{
    public int Id { get; set; }

    public string Role { get; set; } = null!;
}
