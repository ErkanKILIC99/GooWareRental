using GooWareRental.BusinessLogicLayer.Abstracts;
using GooWareRental.BusinessLogicLayer.Concretes;
using GooWareRental.DataAccessLayer.Concretes.EntityFramework;
using GooWareRental.Entities.Concretes;
using System;

namespace GooWareRental.ConsoleUI
{
    class Program
    {
        static IColorService _colorService = new ColorManager(new EFColorDal());
        static void Main(string[] args)
        {
            //CreateColorTest(); BAŞARILI
            //UpdateColorTest(); BAŞARILI
            //DeleteColorTest(); BAŞARILI
            //GetColorById(); BAŞARILI
            //GetAllColors(); BAŞARILI
            Console.ReadKey();
        }

        #region ColorTest
        static void CreateColorTest()
        {
            var request = _colorService.CreateColor(new Color() { ColorName = "Test Color", ColorState = false });
            Console.WriteLine(request.Message);
        }
        static void UpdateColorTest()
        {
            var request = _colorService.UpdateColor(new Color() { ColorId = 1, ColorName = "Test Color - Updated", ColorState = false });
            Console.WriteLine(request.Message);
        }
        static void DeleteColorTest()
        {
            var request = _colorService.DeleteColor(new Color() { ColorId = 1, ColorName = "Test Color - Updated", ColorState = false });
            Console.WriteLine(request.Message);
        }
        static void GetColorById()
        {
            var request = _colorService.GetColorById(2);
            Console.WriteLine(request.Data.ColorName);
        }
        static void GetAllColors()
        {
            var request = _colorService.GetAllColors();
            foreach (var color in request.Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }
        #endregion
    }
}
