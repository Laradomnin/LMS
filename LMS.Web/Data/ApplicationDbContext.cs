using LMS.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LMS.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Course> Courses =>Set<Course>();
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}