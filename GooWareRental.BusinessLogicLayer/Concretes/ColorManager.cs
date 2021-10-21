using GooWareRental.BusinessLogicLayer.Abstracts;
using GooWareRental.BusinessLogicLayer.BusinessAspects.Autofac;
using GooWareRental.BusinessLogicLayer.ResultMessages;
using GooWareRental.BusinessLogicLayer.ValidationRules.FluentValidation;
using GooWareRental.Core.Aspects.Autofac.Caching;
using GooWareRental.Core.Aspects.Autofac.Performance;
using GooWareRental.Core.Aspects.Autofac.Validation;
using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Core.Utilities.Concretes;
using GooWareRental.DataAccessLayer.Abstracts;
using GooWareRental.Entities.Concretes;
using System.Collections.Generic;

namespace GooWareRental.BusinessLogicLayer.Concretes
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(ColorValidator))]
        [CacheRemoveAspect("IColorService.Get")]
        public IResult CreateColor(Color color)
        {
            if (_colorDal.Insert(color)) return new SuccessResult(ColorMessage.MSG_COLOR_CREATED);
            else return new ErrorResult(ColorMessage.MSG_COLOR_NOT_CREATED);
        }

        [CacheRemoveAspect("IColorService.Get")]
        public IResult UpdateColor(Color color)
        {
            if (_colorDal.Update(color)) return new SuccessResult(ColorMessage.MSG_COLOR_UPDATED);
            else return new ErrorResult(ColorMessage.MSG_COLOR_NOT_UPDATED);
        }

        [CacheRemoveAspect("IColorService.Get")]
        public IResult DeleteColor(Color color)
        {
            if (_colorDal.Delete(color)) return new SuccessResult(ColorMessage.MSG_COLOR_DELETED);
            else return new ErrorResult(ColorMessage.MSG_COLOR_NOT_DELETED);
        }

        [PerformanceAspect(5)]
        public IDataResult<Color> GetColorById(short colorId)
        {
            var data = _colorDal.Get(color => color.ColorId == colorId);
            if (data != null) return new SuccessDataResult<Color>(data, ColorMessage.MSG_GETTED_BY_COLOR);
            else return new SuccessDataResult<Color>(null, ColorMessage.MSG_NOT_GETTED_BY_COLOR);
        }

        public IDataResult<Color> GetColorByName(string colorName)
        {
            var data = _colorDal.Get(color => color.ColorName == colorName);
            if (data != null) return new SuccessDataResult<Color>(data, ColorMessage.MSG_GETTED_BY_COLOR);
            else return new SuccessDataResult<Color>(null, ColorMessage.MSG_NOT_GETTED_BY_COLOR);
        }

        [CacheAspect]
        public IDataResult<List<Color>> GetAllColors()
        {
            var data = _colorDal.GetAll();
            if (data.Count > 0) return new SuccessDataResult<List<Color>>(data, ColorMessage.MSG_GETTED_BY_COLOR);
            else return new SuccessDataResult<List<Color>>(null, ColorMessage.MSG_NOT_GETTED_BY_COLOR);
        }
    }
}