using System.Collections.Generic;
using StudentManagementAPI.DataModels;

namespace StudentManagementAPI.Repositories
{
    public interface IStudentRepository 
    {
        List<Studentt> GetStudents();
    }
}
