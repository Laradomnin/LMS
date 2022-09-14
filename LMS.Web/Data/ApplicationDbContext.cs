using LMS.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LMS.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; } = default!;
        public DbSet<Module> Modules => Set<Module>();
        public DbSet<Document> Documents => Set<Document>();


        
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //FluentAPI
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Course>()
        //        .HasMany(c => c.Modules);
        //        //.WithMany(m => m.Activities)
        //        modelBuilder.Entity<Document>(
        //            d => d.HasOne(d => d.Course).WithMany(c => c.Modules),
        //            d => d.HasOne(e => e.User).WithMany(u => u.Documents));



        //}
    }
}