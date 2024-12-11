using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityUser
{
    public long Id { get; set; }

    public long ActivityId { get; set; }

    public long UserId { get; set; }

    public string? Username { get; set; }

    public string? Fullname { get; set; }

    public string? Team { get; set; }

    public string? Company { get; set; }

    public byte[]? PhotoPreview { get; set; }
}
