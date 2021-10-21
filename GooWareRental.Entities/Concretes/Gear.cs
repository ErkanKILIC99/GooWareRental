using GooWareRental.Core.Entities;

namespace GooWareRental.Entities.Concretes
{
    public class Gear : IEntity
    {
        public short GearId { get; set; }
        public string GearName { get; set; }
        public bool GearState { get; set; }
    }
}
