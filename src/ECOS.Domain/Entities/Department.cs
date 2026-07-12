using System.Collections.Generic;
using ECOS.Domain.Common;
namespace ECOS.Domain.Entities;

public class Department : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Code { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;
    public Guid OrganizationId { get; set; }

    public Organization? Organization { get; set; }
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}