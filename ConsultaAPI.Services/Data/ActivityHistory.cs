using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class ActivityHistory
{
    public long Id { get; set; }

    public DateTime LastUpdate { get; set; }

    public long ActivityId { get; set; }

    public string? Code { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? FinishDate { get; set; }

    public int StateId { get; set; }

    public string? State { get; set; }

    public long UserId { get; set; }

    public string? Username { get; set; }

    public string? Comments { get; set; }

    public string? Attachment { get; set; }

    public bool? IsRequest { get; set; }

    public DateOnly? StartDateRequest { get; set; }

    public DateOnly? FinishDateRequest { get; set; }
}
