using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Respositories
{
    public interface IStudentRepository
    {
        public IList<Student> GetAllStudents();
    }
}
