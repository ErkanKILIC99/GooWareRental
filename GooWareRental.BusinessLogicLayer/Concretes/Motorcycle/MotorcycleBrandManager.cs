using GooWareRental.BusinessLogicLayer.Abstracts.Motorcycle;
using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Core.Utilities.Concretes;
using GooWareRental.DataAccessLayer.Abstracts.Motorcycle;
using GooWareRental.Entities.Concretes.Motorcycle;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Concretes.Motorcycle
{
    public class MotorcycleBrandManager : IMotorcycleBrandService
    {
        IMotorcycleBrandDal _motorcycleBrandDal;

        public MotorcycleBrandManager(IMotorcycleBrandDal motorcycleBrandDal)
        {
            _motorcycleBrandDal = motorcycleBrandDal;
        }

        public IResult CreateMotorcycleBrand(MotorcycleBrand motorcycleBrand)
        {
            if (_motorcycleBrandDal.Insert(motorcycleBrand)) return new SuccessResult();
            else return new ErrorResult();
        }

        public IResult UpdateMotorcycleBrand(MotorcycleBrand motorcycleBrand)
        {
            if (_motorcycleBrandDal.Update(motorcycleBrand)) return new SuccessResult();
            else return new ErrorResult();
        }

        public IResult DeleteMotorcycleBrand(MotorcycleBrand motorcycleBrand)
        {
            if (_motorcycleBrandDal.Delete(motorcycleBrand)) return new SuccessResult();
            else return new ErrorResult();
        }

        public IDataResult<MotorcycleBrand> GetMotorcycleBrandById(short motorcycleBrandId)
        {
            var data = _motorcycleBrandDal.Get(motorcycleBrand => motorcycleBrand.MotorcycleBrandId == motorcycleBrandId);
            if (data != null) return new SuccessDataResult<MotorcycleBrand>(data);
            return new ErrorDataResult<MotorcycleBrand>(null);
        }

        public IDataResult<MotorcycleBrand> GetMotorcycleBrandByName(string motorcycleBrandName)
        {
            var data = _motorcycleBrandDal.Get(motorcycleBrand => motorcycleBrand.MotorcycleBrandName == motorcycleBrandName);
            if (data != null) return new SuccessDataResult<MotorcycleBrand>(data);
            return new ErrorDataResult<MotorcycleBrand>(null);
        }

        public IDataResult<List<MotorcycleBrand>> GetAllMotorcycleBrands()
        {
            var data = _motorcycleBrandDal.GetAll();
            if (data.Count > 0) return new SuccessDataResult<List<MotorcycleBrand>>(data);
            return new ErrorDataResult<List<MotorcycleBrand>>(null);
        }
    }
}
