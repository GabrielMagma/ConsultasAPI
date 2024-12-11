using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SettingRegion
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public long? IdZone { get; set; }

    public virtual SettingZone? IdZoneNavigation { get; set; }

    public virtual ICollection<SettingSector> SettingSectors { get; set; } = new List<SettingSector>();
}
