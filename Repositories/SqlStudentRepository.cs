using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.DataModels;

namespace StudentManagementAPI.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;
        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;

        }
        public List<Studentt> GetStudents()
        {
            return context.Studentt
                .Include(nameof(Gender))
                .Include(nameof(Address))
                .ToList();
        }

    }
}
