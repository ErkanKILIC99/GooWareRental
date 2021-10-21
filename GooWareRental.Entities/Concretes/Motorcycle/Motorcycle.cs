using GooWareRental.Core.Entities;

namespace GooWareRental.Entities.Concretes.Motorcycle
{
    public class Motorcycle : IEntity
    {
        public int MotorcycleId { get; set; }
        public short ColorId { get; set; }
        public short GearId { get; set; }
        public int MotorcycleBrandId { get; set; }
        public int MotorcycleModelId { get; set; }
        public int MotorcyclePackageId { get; set; }
        public short MotorcycleTypeId { get; set; }
        public int MotorcycleImageId { get; set; }
    }
}
