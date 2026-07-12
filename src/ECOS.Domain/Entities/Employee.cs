using ECOS.Domain.Common;

namespace ECOS.Domain.Entities;

public class Employee : BaseAuditableEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string? NationalCode { get; set; }

    public string? PersonnelCode { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public bool IsActive { get; set; } = true;

    public Guid DepartmentId { get; set; }

    public Department? Department { get; set; }
}