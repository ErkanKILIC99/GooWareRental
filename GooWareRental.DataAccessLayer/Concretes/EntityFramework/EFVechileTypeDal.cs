﻿using GooWareRental.Core.DataAccessLayer.EntityFramework;
using GooWareRental.DataAccessLayer.Abstracts;
using GooWareRental.DataAccessLayer.Contexts;
using GooWareRental.Entities.Concretes;

namespace GooWareRental.DataAccessLayer.Concretes.EntityFramework
{
    public class EFVechileTypeDal : EntityFrameworkRepositoryBase<VechileType, GooWareRentalContext> ,IVechileTypeDal
    {
    }
}
