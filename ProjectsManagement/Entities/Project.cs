using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectsManagement.Entities;

[Index(nameof(Name), IsUnique = true)]
internal class Project
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public ProgressStatuses Status { get; set; }

    public bool IsActive { get; set; }

    public int TypeId { get; set; }

    public ProjectType Type { get; set; }

    public List<ProjectMember> Members { get; set; }

    public List<Task> Tasks { get; set; }
}