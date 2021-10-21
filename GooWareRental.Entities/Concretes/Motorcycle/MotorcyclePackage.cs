using GooWareRental.Core.Entities;

namespace GooWareRental.Entities.Concretes.Motorcycle
{
    public class MotorcyclePackage : IEntity
    {
        public int MotorcyclePackageId { get; set; }
        public int MotorcycleModelId { get; set; }
        public string MotorcyclePackageName { get; set; }
        public bool MotorcyclePackageState { get; set; }
    }
}
