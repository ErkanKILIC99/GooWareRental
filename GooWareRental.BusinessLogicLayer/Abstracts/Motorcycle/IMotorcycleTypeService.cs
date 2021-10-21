using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Entities.Concretes.Motorcycle;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Abstracts.Motorcycle
{
    public interface IMotorcycleTypeService
    {
        IResult CreateMotorcycleType(MotorcycleType motorcycleType);
        IResult UpdateMotorcycleType(MotorcycleType motorcycleType);
        IResult DeleteMotorcycleType(MotorcycleType motorcycleType);
        IDataResult<MotorcycleType> GetMotorcycleTypeById(short motorcycleTypeId);
        IDataResult<MotorcycleType> GetMotorcycleTypeByName(string motorcycleTypeName);
        IDataResult<List<MotorcycleType>> GetAllMotorcycleTypes();
    }
}
