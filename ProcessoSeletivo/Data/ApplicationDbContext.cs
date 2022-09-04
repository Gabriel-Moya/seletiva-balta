using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProcessoSeletivo.Models;

namespace ProcessoSeletivo.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Module> Modules { get; set; }
    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //base.OnModelCreating(builder);

        //Cursos
        builder.Entity<Course>(builder =>
        {
            builder.HasKey(x => x.Id);
        });
        builder.Entity<Course>(builder =>
        {
            builder.HasMany(x => x.Modules)
                .WithOne();
        });

        //Módulos
        builder.Entity<Module>(builder =>
        {
            builder.HasKey(x => x.Id);
        });
        builder.Entity<Module>(builder =>
        {
            builder.HasMany(x => x.Lessons)
                .WithOne();
        });

        //Aulas
        builder.Entity<Lesson>(builder =>
        {
            builder.HasKey(x => x.Id);
        });

        base.OnModelCreating(builder);
    }
}
