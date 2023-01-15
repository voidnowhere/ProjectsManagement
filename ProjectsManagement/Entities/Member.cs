using System.Collections.Generic;

namespace ProjectsManagement.Entities;

public class Member : Person
{
    public bool IsActive { get; set; }
    
    public List<ProjectType> Competencies { get; set; }
    
    public List<Project> Projects { get; set; }
    
    public List<Task> Tasks { get; set; }
}