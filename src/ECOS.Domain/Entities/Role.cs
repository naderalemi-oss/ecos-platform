using System.Collections.Generic;
using ECOS.Domain.Common;
namespace ECOS.Domain.Entities;

public class Role : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Code { get; set; }

    public string? Description { get; set; }

    public bool IsSystemRole { get; set; } = false;

    public bool IsActive { get; set; } = true;
    public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}