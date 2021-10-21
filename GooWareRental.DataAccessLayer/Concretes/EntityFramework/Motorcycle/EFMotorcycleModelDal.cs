using GooWareRental.Core.DataAccessLayer.EntityFramework;
using GooWareRental.DataAccessLayer.Abstracts.Motorcycle;
using GooWareRental.DataAccessLayer.Contexts;
using GooWareRental.Entities.Concretes.Motorcycle;

namespace GooWareRental.DataAccessLayer.Concretes.EntityFramework.Motorcycle
{
    public class EFMotorcycleModelDal : EntityFrameworkRepositoryBase<MotorcycleModel, GooWareRentalContext>, IMotorcycleModelDal
    {
    }
}
