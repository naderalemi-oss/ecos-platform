using System.Collections.Generic;
using ECOS.Domain.Common;
using ECOS.Domain.Enums;

namespace ECOS.Domain.Entities;

public class Organization : BaseAuditableEntity
{
    public OrganizationType Type { get; set; } = OrganizationType.Private;
    public string Name { get; set; } = string.Empty;

    public string? Code { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;
    public ICollection<Department> Departments { get; set; } = new List<Department>();
}