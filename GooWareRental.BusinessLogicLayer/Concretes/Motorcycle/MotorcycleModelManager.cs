using GooWareRental.BusinessLogicLayer.Abstracts.Motorcycle;
using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Core.Utilities.Concretes;
using GooWareRental.DataAccessLayer.Abstracts.Motorcycle;
using GooWareRental.Entities.Concretes.Motorcycle;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Concretes.Motorcycle
{
    public class MotorcycleModelManager : IMotorcycleModelService
    {
        IMotorcycleModelDal _motorcycleModelDal;

        public MotorcycleModelManager(IMotorcycleModelDal motorcycleModelDal)
        {
            _motorcycleModelDal = motorcycleModelDal;
        }

        public IResult CreateMotorcycleModel(MotorcycleModel motorcycleModel)
        {
            if (_motorcycleModelDal.Insert(motorcycleModel)) return new SuccessResult();
            return new ErrorResult();
        }

        public IResult UpdateMotorcycleModel(MotorcycleModel motorcycleModel)
        {
            if (_motorcycleModelDal.Update(motorcycleModel)) return new SuccessResult();
            return new ErrorResult();
        }

        public IResult DeleteMotorcycleModel(MotorcycleModel motorcycleModel)
        {
            if (_motorcycleModelDal.Delete(motorcycleModel)) return new SuccessResult();
            return new ErrorResult();
        }

        public IDataResult<MotorcycleModel> GetMotorcycleModelById(short motorcycleModelId)
        {
            var data = _motorcycleModelDal.Get(motorcycleModel => motorcycleModel.MotorcycleModelId == motorcycleModelId);
            if (data != null) return new SuccessDataResult<MotorcycleModel>(data);
            return new ErrorDataResult<MotorcycleModel>(null);
        }

        public IDataResult<MotorcycleModel> GetMotorcycleModelByName(string motorcycleModelName)
        {
            var data = _motorcycleModelDal.Get(motorcycleModel => motorcycleModel.MotorcycleModelName == motorcycleModelName);
            if (data != null) return new SuccessDataResult<MotorcycleModel>(data);
            return new ErrorDataResult<MotorcycleModel>(null);
        }

        public IDataResult<List<MotorcycleModel>> GetAllMotorcycleModels()
        {
            var data = _motorcycleModelDal.GetAll();
            if (data.Count > 0) return new SuccessDataResult<List<MotorcycleModel>>(data);
            return new ErrorDataResult<List<MotorcycleModel>>(null);
        }
    }
}
