using GooWareRental.Core.Entities;

namespace GooWareRental.Entities.DataTransformationObjects
{
    public class UserForRegisterDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
