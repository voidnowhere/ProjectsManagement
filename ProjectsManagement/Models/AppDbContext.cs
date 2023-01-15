using Microsoft.EntityFrameworkCore;
using ProjectsManagement.Entities;

namespace ProjectsManagement.Models;

internal class AppDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    
    public DbSet<Manager> Managers { get; set; }
    
    public DbSet<Member> Members { get; set; }
    
    public DbSet<MemberCompetencies> MembersCompetencies { get; set; }
    
    public DbSet<ProjectType> ProjectTypes { get; set; }
    
    public DbSet<ProjectMembers> ProjectsMembers { get; set; }
    
    public DbSet<Project> Projects { get; set; }
    
    public DbSet<Entities.Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(local);Database=ProjectsManagement;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Cascade Restrict
        modelBuilder.Entity<Project>()
            .HasOne(p => p.Type)
            .WithMany(t => t.Projects)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Entities.Task>()
            .HasOne(t => t.Project)
            .WithMany(p => p.Tasks)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Entities.Task>()
           .HasOne(t => t.Member)
           .WithMany(m => m.Tasks)
           .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<ProjectMembers>()
            .HasOne(pm => pm.Member)
            .WithMany(m => m.Projects)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<ProjectMembers>()
            .HasOne(pm => pm.Project)
            .WithMany(m => m.Members)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<MemberCompetencies>()
            .HasOne(mc => mc.Member)
            .WithMany(m => m.Competencies)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<MemberCompetencies>()
            .HasOne(mc => mc.Competence)
            .WithMany(c => c.MembersCompetencies)
            .OnDelete(DeleteBehavior.Restrict);
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