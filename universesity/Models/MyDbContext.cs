
using universesity.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    // Define DbSet properties for your models here
    public DbSet<Admin> Admins { get; set; }

    public DbSet<Subject> Subject { get; set; }
    public DbSet<Student> Students { get; set; }

    public DbSet<Room> Rooms { get; set; }
    public DbSet<Class> Classes { get; set; }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Username = "admin", Password = "admin", Role = "Admin" },
            new User { Id = 2, Username = "student", Password = "student", Role = "Student" }
        );
    }


}