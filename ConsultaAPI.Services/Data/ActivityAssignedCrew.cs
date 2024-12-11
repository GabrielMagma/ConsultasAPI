using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityAssignedCrew
{
    public long Id { get; set; }

    public long ActivityId { get; set; }

    public long CrewId { get; set; }
}
