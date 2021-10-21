using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Entities.Concretes.Motorcycle;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Abstracts.Motorcycle
{
    public interface IMotorcyclePackageService
    {
        IResult CreateMotorcyclePackage(MotorcyclePackage motorcyclePackage);
        IResult UpdateMotorcyclePackage(MotorcyclePackage motorcyclePackage);
        IResult DeleteMotorcyclePackage(MotorcyclePackage motorcyclePackage);
        IDataResult<MotorcyclePackage> GetMotorcyclePackageById(short motorcyclePackageId);
        IDataResult<MotorcyclePackage> GetMotorcyclePackageByName(string motorcyclePackageName);
        IDataResult<List<MotorcyclePackage>> GetAllMotorcyclePackages();
    }
}
