using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class AdminUser
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Pswd { get; set; } = null!;

    public string? Phone { get; set; }

    public byte[]? Photo { get; set; }

    public long RoleId { get; set; }

    public string Role { get; set; } = null!;

    public long CompanyId { get; set; }

    public string Company { get; set; } = null!;

    public long TeamId { get; set; }

    public string Team { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime DateCreate { get; set; }

    public DateTime? DateUpdate { get; set; }

    public byte[]? PhotoPreview { get; set; }

    public bool? A2f { get; set; }
}
