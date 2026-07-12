namespace ECOS.Domain.Interfaces;

public interface IAuditableEntity
{
    DateTime CreatedAt { get; }

    DateTime? UpdatedAt { get; }

    bool IsDeleted { get; }
}