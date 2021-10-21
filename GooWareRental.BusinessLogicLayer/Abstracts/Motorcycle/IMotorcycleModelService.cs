using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Entities.Concretes.Motorcycle;
using System;
using System.Collections.Generic;
using System.Text;

namespace GooWareRental.BusinessLogicLayer.Abstracts.Motorcycle
{
    public interface IMotorcycleModelService
    {
        IResult CreateMotorcycleModel(MotorcycleModel motorcycleModel);
        IResult UpdateMotorcycleModel(MotorcycleModel motorcycleModel);
        IResult DeleteMotorcycleModel(MotorcycleModel motorcycleModel);
        IDataResult<MotorcycleModel> GetMotorcycleModelById(short motorcycleModelId);
        IDataResult<MotorcycleModel> GetMotorcycleModelByName(string motorcycleModelName);
        IDataResult<List<MotorcycleModel>> GetAllMotorcycleModels();
    }
}
