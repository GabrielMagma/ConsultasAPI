using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

/// <summary>
/// RESUMIR POR AÑO - MES LA CANTIDAD DE EVENTOS ASOCIADOS A UN UIA EN ESPECIFICO
/// </summary>
public partial class EventCountLac
{
    public long Id { get; set; }

    public string CodeEvent { get; set; } = null!;

    public string CountUia { get; set; } = null!;

    public int? Year { get; set; }

    public int? Month { get; set; }
}
