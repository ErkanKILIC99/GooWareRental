using GooWareRental.Core.Entities;

namespace GooWareRental.Entities.Concretes.Motorcycle
{
    public class MotorcycleModel : IEntity
    {
        public int MotorcycleModelId { get; set; }
        public int MotorcycleBrandId { get; set; }
        public string MotorcycleModelName { get; set; }
        public bool MotorcycleModelState { get; set; }
    }
}