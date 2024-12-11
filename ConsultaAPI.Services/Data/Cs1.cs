using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class Cs1
{
    public int Year { get; set; }

    public int Month { get; set; }

    public decimal Saidi { get; set; }

    public decimal Saifi { get; set; }

    public decimal Maifi { get; set; }

    public decimal Caidi { get; set; }
}
