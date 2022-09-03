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

    DbSet<Lesson> Lessons { get; set; }
    DbSet<Module> Modules { get; set; }
    DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //Aulas
        builder.Entity<Lesson>(builder =>
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Module)
                .WithMany(x => x.Lessons);
        });

        //Módulos
        builder.Entity<Module>(builder =>
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Course)
                .WithMany(x => x.Modules);
        });

        //Cursos
        builder.Entity<Course>(builder =>
        {
            builder.HasKey(x => x.Id);
        });

        base.OnModelCreating(builder);
    }
}
