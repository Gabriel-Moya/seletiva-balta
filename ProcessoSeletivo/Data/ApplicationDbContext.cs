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
}
