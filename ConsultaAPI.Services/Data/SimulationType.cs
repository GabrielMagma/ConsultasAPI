using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

/// <summary>
/// La tabla SimulationTypes almacena los distintos tipos de simulaciones que pueden ser realizadas en el sistema. Cada tipo de simulación representa una categoría o clase de simulación con características y objetivos específicos
/// </summary>
public partial class SimulationType
{
    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
