using System.ComponentModel.DataAnnotations;

namespace StudentAdminPortal.API.DataModels
{
    public class Gender
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
