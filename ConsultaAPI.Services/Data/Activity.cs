using System;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Data;

public partial class Activity
{
    public long Id { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string? Code { get; set; }

    public string? Title { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? FinishDate { get; set; }

    public long RegionId { get; set; }

    public string RegionName { get; set; } = null!;

    public string? Fparent { get; set; }

    public long? TypeId { get; set; }

    public string? ActivityType { get; set; }

    public long? PriorityId { get; set; }

    public string? Priority { get; set; }

    public long? StateId { get; set; }

    public string? State { get; set; }

    public string? Description { get; set; }

    public string? ImageMap { get; set; }

    public string? Attachment { get; set; }

    public bool? IsGeodata { get; set; }

    public bool? IsRequest { get; set; }

    public bool? IsApproved { get; set; }

    public DateOnly? DateCreate { get; set; }

    public long UserIdCreate { get; set; }

    public string? UsernameCreate { get; set; }

    public DateTime? DateUpdate { get; set; }

    public long UserIdUpdate { get; set; }

    public string? UsernameUpdate { get; set; }
}
