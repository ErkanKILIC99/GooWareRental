using GooWareRental.BusinessLogicLayer.Abstracts.Motorcycle;
using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Entities.Concretes.Motorcycle;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Concretes.Motorcycle
{
    public class MotorcycleTypeManager : IMotorcycleTypeService
    {
        public IResult CreateMotorcycleType(MotorcycleType motorcycleType)
        {
            throw new System.NotImplementedException();
        }

        public IResult UpdateMotorcycleType(MotorcycleType motorcycleType)
        {
            throw new System.NotImplementedException();
        }

        public IResult DeleteMotorcycleType(MotorcycleType motorcycleType)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<MotorcycleType> GetMotorcycleTypeById(short motorcycleTypeId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<MotorcycleType> GetMotorcycleTypeByName(string motorcycleTypeName)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<MotorcycleType>> GetAllMotorcycleTypes()
        {
            throw new System.NotImplementedException();
        }
    }
}
