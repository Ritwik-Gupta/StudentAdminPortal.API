using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Respositories
{
    public interface IStudentRepository
    {
        public Task<IList<Student>> GetAllStudents();
    }
}
