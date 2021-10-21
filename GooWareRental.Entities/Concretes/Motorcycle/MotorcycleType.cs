using GooWareRental.Core.Entities;

namespace GooWareRental.Entities.Concretes.Motorcycle
{
    public class MotorcycleType : IEntity
    {
        public short MotorcycleTypeId { get; set; }
        public string MotorcycleTypeName { get; set; }
        public bool MotorcycleTypeState { get; set; }
    }
}