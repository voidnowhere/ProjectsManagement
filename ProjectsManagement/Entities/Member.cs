using System.Collections.Generic;

namespace ProjectsManagement.Entities;

internal class Member : Person
{
    public bool IsActive { get; set; }
    
    public List<MemberCompetencies> Competencies { get; set; }
    
    public List<ProjectMembers> Projects { get; set; }
    
    public List<Task> Tasks { get; set; }
}