using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class SettingLocalityRegion
{
    public long Id { get; set; }

    public long IdLocality { get; set; }

    public long IdRegion { get; set; }

    public virtual SettingLocality IdLocalityNavigation { get; set; } = null!;
}
