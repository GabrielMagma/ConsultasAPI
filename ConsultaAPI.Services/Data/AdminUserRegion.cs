using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class AdminUserRegion
{
    public long Id { get; set; }

    public long IdUser { get; set; }

    public long IdRegion { get; set; }
}
