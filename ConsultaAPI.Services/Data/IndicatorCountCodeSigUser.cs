using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class IndicatorCountCodeSigUser
{
    public int Year { get; set; }

    public int Month { get; set; }

    public string CodeSig { get; set; } = null!;

    public int Users { get; set; }
}
