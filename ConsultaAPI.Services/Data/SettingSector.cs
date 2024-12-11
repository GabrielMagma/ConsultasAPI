using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SettingSector
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? IdLocality { get; set; }

    public long? IdRegion { get; set; }

    public virtual SettingLocality? IdLocalityNavigation { get; set; }

    public virtual SettingRegion? IdRegionNavigation { get; set; }
}
