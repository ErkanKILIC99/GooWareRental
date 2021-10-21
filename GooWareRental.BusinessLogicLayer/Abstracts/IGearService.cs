using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Entities.Concretes;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Abstracts
{
    public interface IGearService
    {
        IResult CreateGear(Gear gear);
        IResult UpdateGear(Gear gear);
        IResult DeleteGear(Gear gear);
        IDataResult<Gear> GetGearById(short gearId);
        IDataResult<Gear> GetGearByName(string gearName);
        IDataResult<List<Gear>> GetAllGears();
    }
}
