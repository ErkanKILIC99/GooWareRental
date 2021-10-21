using GooWareRental.Core.Entities;

namespace GooWareRental.Entities.Concretes
{
    public class Color : IEntity
    {
        public short ColorId { get; set; }
        public string ColorName { get; set; }
        public bool ColorState { get; set; }
    }
}
