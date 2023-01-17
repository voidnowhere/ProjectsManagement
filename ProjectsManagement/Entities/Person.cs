using Microsoft.EntityFrameworkCore;

namespace ProjectsManagement.Entities;

[Index(nameof(NIC), IsUnique = true)]
[Index(nameof(Email), IsUnique = true)]
public class Person
{
    public int Id { get; set; }
    
    public string LastName { get; set; }
    
    public string FirstName { get; set; }
    
    public string NIC { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }

    public string FullName => FirstName + " " + LastName;
}