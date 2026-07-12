using ECOS.Domain.Common;

namespace ECOS.Domain.Entities;

public class UserRole : BaseAuditableEntity
{
    public Guid UserId { get; set; }

    public User? User { get; set; }

    public Guid RoleId { get; set; }

    public Role? Role { get; set; }
}