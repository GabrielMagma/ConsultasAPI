using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class FilesTc1Temp
{
    public long? Id { get; set; }

    public string? Niu { get; set; }

    public string? Uia { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string? Files { get; set; }

    public DateOnly? FilesDate { get; set; }
}
