using GooWareRental.Core.Entities;

namespace GooWareRental.Entities.Concretes.Motorcycle
{
    public class MotorcycleBrand : IEntity
    {
        public int MotorcycleBrandId { get; set; }
        public string MotorcycleBrandName { get; set; }
        public bool MotorcycleBrandState { get; set; }
    }
}
