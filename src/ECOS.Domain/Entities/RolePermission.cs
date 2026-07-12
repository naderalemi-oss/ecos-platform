using ECOS.Domain.Common;

namespace ECOS.Domain.Entities;

public class RolePermission : BaseAuditableEntity
{
    public Guid RoleId { get; set; }

    public Role? Role { get; set; }

    public Guid PermissionId { get; set; }

    public Permission? Permission { get; set; }
}