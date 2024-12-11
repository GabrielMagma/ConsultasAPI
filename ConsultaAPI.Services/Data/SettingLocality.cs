using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SettingLocality
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<SettingLocalityRegion> SettingLocalityRegions { get; set; } = new List<SettingLocalityRegion>();

    public virtual ICollection<SettingSector> SettingSectors { get; set; } = new List<SettingSector>();
}
