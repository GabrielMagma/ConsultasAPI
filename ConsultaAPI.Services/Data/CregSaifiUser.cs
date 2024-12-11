using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CregSaifiUser
{
    public int Year { get; set; }

    public int Month { get; set; }

    public int IdRegion { get; set; }

    public string NameRegion { get; set; } = null!;

    public int IdLocality { get; set; }

    public string NameLocality { get; set; } = null!;

    public string CodeSig { get; set; } = null!;

    public string? Fparent { get; set; }

    public string? Group015 { get; set; }

    public string? Codetaxo { get; set; }

    public string? Uia { get; set; }

    public int CauseCreg { get; set; }

    public int CauseSui { get; set; }

    public int? CountUser { get; set; }

    public float Saifi { get; set; }
}
