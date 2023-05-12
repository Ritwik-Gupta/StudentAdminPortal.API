using StudentAdminPortal.API.Data;
using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Respositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Student> GetAllStudents()
        {
            return _context.Student.ToList();
        }
    }
}
