using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectsManagement.Entities;

[Index(nameof(Name), IsUnique = true)]
internal class ProjectType
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public List<Project> Projects { get; set; }
    
    public List<MemberCompetencies> MembersCompetencies { get; set; }
}