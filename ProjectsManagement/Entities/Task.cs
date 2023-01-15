using Microsoft.EntityFrameworkCore;

namespace ProjectsManagement.Entities;

[Index(nameof(Name), IsUnique = true)]
internal class Task
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public ProgressStatuses Status { get; set; }

    public int ProjectId { get; set; }

    public Project Project { get; set; }

    public int MemberId { get; set; }

    public Member Member { get; set; }
}