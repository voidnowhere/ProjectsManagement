using Microsoft.EntityFrameworkCore;
using ProjectsManagement.Entities;

namespace ProjectsManagement.Models;

public class AppDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<ProjectType> ProjectTypes { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Entities.Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(local);Database=ProjectsManagement;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Default values
        modelBuilder.Entity<Project>().Property(p => p.Status).HasDefaultValue(ProgressStatuses.To_Do);
        modelBuilder.Entity<Entities.Task>().Property(p => p.Status).HasDefaultValue(ProgressStatuses.To_Do);
        // ProgressStatuses Enum
        modelBuilder.Entity<Project>().Property(p => p.Status).HasConversion(
            s => s.ToString(),
            s => (ProgressStatuses)Enum.Parse(typeof(ProgressStatuses), s)
        );
        modelBuilder.Entity<Entities.Task>().Property(p => p.Status).HasConversion(
            s => s.ToString(),
            s => (ProgressStatuses)Enum.Parse(typeof(ProgressStatuses), s)
        );
    }
}