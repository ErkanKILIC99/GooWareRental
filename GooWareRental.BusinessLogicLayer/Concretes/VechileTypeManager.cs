using GooWareRental.BusinessLogicLayer.Abstracts;
using GooWareRental.BusinessLogicLayer.ResultMessages;
using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Core.Utilities.Concretes;
using GooWareRental.DataAccessLayer.Abstracts;
using GooWareRental.Entities.Concretes;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Concretes
{
    public class VechileTypeManager : IVechileTypeService
    {
        IVechileTypeDal _vechileTypeDal;

        public VechileTypeManager(IVechileTypeDal vechileTypeDal)
        {
            _vechileTypeDal = vechileTypeDal;
        }

        public IResult CreateVechileType(VechileType vechileType)
        {
            if (_vechileTypeDal.Insert(vechileType)) return new SuccessResult(VechileTypeMessage.MSG_VECHILE_TYPE_CREATED);
            else return new ErrorResult(VechileTypeMessage.MSG_VECHILE_TYPE_NOT_CREATED);
        }

        public IResult UpdateVechileType(VechileType vechileType)
        {
            if (_vechileTypeDal.Update(vechileType)) return new SuccessResult(VechileTypeMessage.MSG_VECHILE_TYPE_UPDATED);
            else return new ErrorResult(VechileTypeMessage.MSG_VECHILE_TYPE_NOT_UPDATED);
        }

        public IResult DeleteVechileType(VechileType vechileType)
        {
            if (_vechileTypeDal.Delete(vechileType)) return new SuccessResult(VechileTypeMessage.MSG_VECHILE_TYPE_DELETED);
            else return new ErrorResult(VechileTypeMessage.MSG_VECHILE_TYPE_NOT_DELETED);
        }

        public IDataResult<VechileType> GetVechileTypeById(short vechileTypeId)
        {
            var data = _vechileTypeDal.Get(vechileType => vechileType.VechileTypeId == vechileTypeId);
            if (data != null) return new SuccessDataResult<VechileType>(data, VechileTypeMessage.MSG_GETTED_BY_VECHILE_TYPE);
            else return new SuccessDataResult<VechileType>(null, VechileTypeMessage.MSG_NOT_GETTED_BY_VECHILE_TYPE);
        }

        public IDataResult<VechileType> GetVechileTypeByName(string vechileTypeName)
        {
            var data = _vechileTypeDal.Get(vechileType => vechileType.VechileTypeName == vechileTypeName);
            if (data != null) return new SuccessDataResult<VechileType>(data, VechileTypeMessage.MSG_GETTED_BY_VECHILE_TYPE);
            else return new SuccessDataResult<VechileType>(null, VechileTypeMessage.MSG_NOT_GETTED_BY_VECHILE_TYPE);
        }
        public IDataResult<List<VechileType>> GetAllVechileTypes()
        {
            var data = _vechileTypeDal.GetAll();
            if (data.Count > 0) return new SuccessDataResult<List<VechileType>>(data, VechileTypeMessage.MSG_GETTED_BY_VECHILE_TYPE);
            else return new SuccessDataResult<List<VechileType>>(null, VechileTypeMessage.MSG_NOT_GETTED_BY_VECHILE_TYPE);
        }
    }
}
