using Microsoft.AspNetCore.Identity;
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
        var adminRoleId = Guid.Parse("416F8802-825C-44F4-BC45-3B225D6ED3B2");
        var adminId = Guid.Parse("78088c7d-1b91-4c44-9f77-bea2de6e7886");

        builder.Entity<AppUserRole>().HasData(new List<AppUserRole>
        {
            new AppUserRole()
            {
                Id = adminRoleId,
                Name = "Admin"
            }
        });
        PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();

        var admin1 = new AppUser()
        {
            Id = adminId,
            FirstName = "Abdulaziz",
            LastName = "Anduqaxxorov",
            UserName = "admin.abdulaziz",
            Email = "Abduqaxxarov04@gmail.com",
        };

        admin1.PasswordHash = passwordHasher.HashPassword(admin1, "admin");

        builder.Entity<AppUser>().HasData(new List<AppUser>
        {
            admin1,
        });

        builder.Entity<IdentityUserRole<Guid>>().HasKey(u => new { u.UserId, u.RoleId });
        builder.Entity<IdentityUserRole<Guid>>().HasData(new List<IdentityUserRole<Guid>>
            {
                new IdentityUserRole<Guid>()
                {
                    UserId = adminId,
                    RoleId = adminRoleId
                }
            });
    }
}
