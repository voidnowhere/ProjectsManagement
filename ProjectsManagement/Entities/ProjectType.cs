using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectsManagement.Entities;

[Index(nameof(Name), IsUnique = true)]
public class ProjectType
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public List<Project> Projects { get; set; }
    
    public List<Member> Members { get; set; }
}