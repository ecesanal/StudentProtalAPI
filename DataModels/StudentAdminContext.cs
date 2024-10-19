using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace StudentManagementAPI.DataModels
{
    public class StudentAdminContext : DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options) : base(options)
        {
        }

        public DbSet<Studentt>? Studentt { get; set; }
        public DbSet<Gender>? Gender { get; set; }
        public DbSet<Address>? Address { get; set; }

    }

}
