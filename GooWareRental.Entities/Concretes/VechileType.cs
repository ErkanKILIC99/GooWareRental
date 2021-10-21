using GooWareRental.Core.Entities;

namespace GooWareRental.Entities.Concretes
{
    public class VechileType : IEntity
    {
        public short VechileTypeId { get; set; }
        public string VechileTypeName { get; set; }
        public bool VechileTypeState { get; set; }
    }
}
