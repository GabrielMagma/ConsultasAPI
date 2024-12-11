using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class CriticalityConsequenceByCircuit
{
    public long Id { get; set; }

    public string Fparent { get; set; } = null!;

    public long? SsId { get; set; }

    public double? SsValue { get; set; }

    public double? SsValueWg { get; set; }

    public long? ImId { get; set; }

    public double? ImValue { get; set; }

    public double? ImValueWg { get; set; }

    public long? EoDnaId { get; set; }

    public double? EoDnaValue { get; set; }

    public double? EoDnaValueWg { get; set; }

    public long? EoTrId { get; set; }

    public double? EoTrValue { get; set; }

    public double? EoTrValueWg { get; set; }

    public long? CfId { get; set; }

    public double? CfValue { get; set; }

    public double? CfValueWg { get; set; }

    public long? IpId { get; set; }

    public double? IpValue { get; set; }

    public double? IpValueWg { get; set; }

    public long? MlId { get; set; }

    public double? MlValue { get; set; }

    public double? MlValueWg { get; set; }

    public int? Year { get; set; }

    public int? ConsequenceNum { get; set; }
}
