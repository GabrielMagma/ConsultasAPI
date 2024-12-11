using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class AdminPermission
{
    public int Id { get; set; }

    public int IdRole { get; set; }

    public int IdOperation { get; set; }
}
