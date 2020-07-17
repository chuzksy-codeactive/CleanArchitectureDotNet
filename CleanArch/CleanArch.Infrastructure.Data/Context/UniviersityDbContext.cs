using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure.Data.Context
{
    public class UniviersityDbContext : DbContext
    {
        public UniviersityDbContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<Course> Courses { get; set; }
    }
}
