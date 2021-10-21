using GooWareRental.BusinessLogicLayer.Abstracts;
using GooWareRental.BusinessLogicLayer.ResultMessages;
using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Core.Utilities.Concretes;
using GooWareRental.DataAccessLayer.Abstracts;
using GooWareRental.Entities.Concretes;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Concretes
{
    public class GearManager : IGearService
    {
        IGearDal _gearDal;

        public GearManager(IGearDal gearDal)
        {
            _gearDal = gearDal;
        }

        public IResult CreateGear(Gear gear)
        {
            if (_gearDal.Insert(gear)) return new SuccessResult(GearMessage.MSG_GEAR_CREATED);
            else return new ErrorResult(GearMessage.MSG_GEAR_NOT_CREATED);
        }

        public IResult UpdateGear(Gear gear)
        {
            if (_gearDal.Update(gear)) return new SuccessResult(GearMessage.MSG_GEAR_UPDATED);
            else return new ErrorResult(GearMessage.MSG_GEAR_NOT_UPDATED);
        }

        public IResult DeleteGear(Gear gear)
        {
            if (_gearDal.Delete(gear)) return new SuccessResult(GearMessage.MSG_GEAR_DELETED);
            else return new ErrorResult(GearMessage.MSG_GEAR_NOT_DELETED);
        }

        public IDataResult<Gear> GetGearById(short gearId)
        {
            var data = _gearDal.Get(gear => gear.GearId == gearId);
            if (data != null) return new SuccessDataResult<Gear>(data, GearMessage.MSG_GETTED_BY_GEAR);
            else return new SuccessDataResult<Gear>(null, GearMessage.MSG_NOT_GETTED_BY_GEAR);
        }

        public IDataResult<Gear> GetGearByName(string gearName)
        {
            var data = _gearDal.Get(gear => gear.GearName == gearName);
            if (data != null) return new SuccessDataResult<Gear>(data, GearMessage.MSG_GETTED_BY_GEAR);
            else return new SuccessDataResult<Gear>(null, GearMessage.MSG_NOT_GETTED_BY_GEAR);
        }
        public IDataResult<List<Gear>> GetAllGears()
        {
            var data = _gearDal.GetAll();
            if (data.Count > 0) return new SuccessDataResult<List<Gear>>(data, GearMessage.MSG_GETTED_BY_GEAR);
            else return new SuccessDataResult<List<Gear>>(null, GearMessage.MSG_NOT_GETTED_BY_GEAR);
        }
    }
}
