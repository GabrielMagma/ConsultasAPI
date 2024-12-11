using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityAsset
{
    public long Id { get; set; }

    public int ActivityId { get; set; }

    public string CodeSig { get; set; } = null!;

    public string Type { get; set; } = null!;
}
