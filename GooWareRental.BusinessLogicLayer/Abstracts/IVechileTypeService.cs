using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Entities.Concretes;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Abstracts
{
    public interface IVechileTypeService
    {
        IResult CreateVechileType(VechileType vechileType);
        IResult UpdateVechileType(VechileType vechileType);
        IResult DeleteVechileType(VechileType vechileType);
        IDataResult<VechileType> GetVechileTypeById(short vechileTypeId);
        IDataResult<VechileType> GetVechileTypeByName(string vechileTypeName);
        IDataResult<List<VechileType>> GetAllVechileTypes();

    }
}
