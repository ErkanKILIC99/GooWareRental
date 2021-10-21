using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Entities.Concretes;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Abstracts
{
    public interface IColorService
    {
        IResult CreateColor(Color color);
        IResult UpdateColor(Color color);
        IResult DeleteColor(Color color);
        IDataResult<Color> GetColorById(short colorId);
        IDataResult<Color> GetColorByName(string colorName);
        IDataResult<List<Color>> GetAllColors();
    }
}
