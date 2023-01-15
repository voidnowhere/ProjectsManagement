using System.Collections.Generic;

namespace ProjectsManagement.Entities;

internal class Member : Person
{
    public bool IsActive { get; set; }
    
    public List<MemberCompetence> Competencies { get; set; }
    
    public List<ProjectMember> Projects { get; set; }
    
    public List<Task> Tasks { get; set; }
}