using AutoMapper;
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
        private readonly IMapper mapper;

        public StudentsController(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {

            IList<DataModels.Student> students = await _studentRepository.GetAllStudents(); //from datamodels

            return  Ok(mapper.Map<IList<DomainModels.Student>>(students));

        }
    }
}
