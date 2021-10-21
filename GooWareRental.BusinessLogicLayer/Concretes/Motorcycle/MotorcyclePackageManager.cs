using GooWareRental.BusinessLogicLayer.Abstracts.Motorcycle;
using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Entities.Concretes.Motorcycle;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Concretes.Motorcycle
{
    public class MotorcyclePackageManager : IMotorcyclePackageService
    {
        public IResult CreateMotorcyclePackage(MotorcyclePackage motorcyclePackage)
        {
            throw new System.NotImplementedException();
        }

        public IResult UpdateMotorcyclePackage(MotorcyclePackage motorcyclePackage)
        {
            throw new System.NotImplementedException();
        }

        public IResult DeleteMotorcyclePackage(MotorcyclePackage motorcyclePackage)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<MotorcyclePackage> GetMotorcyclePackageById(short motorcyclePackageId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<MotorcyclePackage> GetMotorcyclePackageByName(string motorcyclePackageName)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<MotorcyclePackage>> GetAllMotorcyclePackages()
        {
            throw new System.NotImplementedException();
        }
    }
}
