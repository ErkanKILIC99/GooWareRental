using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Entities.Concretes.Motorcycle;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Abstracts.Motorcycle
{
    public interface IMotorcycleBrandService
    {
        IResult CreateMotorcycleBrand(MotorcycleBrand motorcycleBrand);
        IResult UpdateMotorcycleBrand(MotorcycleBrand motorcycleBrand);
        IResult DeleteMotorcycleBrand(MotorcycleBrand motorcycleBrand);
        IDataResult<MotorcycleBrand> GetMotorcycleBrandById(short motorcycleBrandId);
        IDataResult<MotorcycleBrand> GetMotorcycleBrandByName(string motorcycleBrandName);
        IDataResult<List<MotorcycleBrand>> GetAllMotorcycleBrands();
    }
}
