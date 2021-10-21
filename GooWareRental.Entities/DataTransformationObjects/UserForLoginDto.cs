using GooWareRental.Core.Entities;

namespace GooWareRental.Entities.DataTransformationObjects
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
