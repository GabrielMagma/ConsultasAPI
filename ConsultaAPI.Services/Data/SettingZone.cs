using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SettingZone
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<SettingRegion> SettingRegions { get; set; } = new List<SettingRegion>();
}
