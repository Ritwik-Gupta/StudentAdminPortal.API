using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.Data;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Respositories;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {

            IList<DataModels.Student> students =  _studentRepository.GetAllStudents(); //from datamodels

            IList<DomainModels.Student> studentsApi = new List<DomainModels.Student>();

            foreach(var student in students)
            {
                studentsApi.Add(new DomainModels.Student
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    DateOfBirth = student.DateOfBirth,
                    Email = student.Email,
                    Mobile = student.Mobile,
                    ProfileImageUrl = student.ProfileImageUrl,
                    GenderId = student.GenderId,
                });
            }

            return Ok(studentsApi);
        }
    }
}
