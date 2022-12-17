using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Data;

public class AppDbContext : IdentityDbContext<AppUser, AppUserRole, Guid>
{
    public DbSet<Group>? Groups { get; set; }
    public DbSet<Mark>? Marks { get; set; }
    public DbSet<StudyDay>? StudyDays { get; set; }
    public DbSet<StudentStatsOfDay>? StudentStatsOfDays { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<AppUserRole>().HasData(new List<AppUserRole>
        {
            new AppUserRole()
            {
                Id = Guid.NewGuid(),
                Name = "Admin"
            },
            new AppUserRole()
            {
                Id = Guid.NewGuid(),
                Name = "Teacher"
            },
            new AppUserRole()
            {
                Id = Guid.NewGuid(),
                Name = "Student"
            }
        });
    }
}
