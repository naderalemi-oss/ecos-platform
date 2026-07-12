using ECOS.Domain.Common;
using System.Collections.Generic;
namespace ECOS.Domain.Entities;

public class Permission : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public string? Description { get; set; }

    public string? Category { get; set; }

    public bool IsActive { get; set; } = true;
    public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
}