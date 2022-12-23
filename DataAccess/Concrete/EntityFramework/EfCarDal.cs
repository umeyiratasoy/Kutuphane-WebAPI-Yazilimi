using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 CarId = ca.CarId,
                                 CarName = ca.CarName,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 ModelYear = ca.ModelYear

                             };
                return result.ToList();
            }
        }

        public CarDetailDto GetCarDetailsById(int id)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             where ca.CarId == id
                             select new CarDetailDto
                             {
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 BrandId = br.Id,
                                 ColorId = co.Id,
                                 CarId = ca.CarId,
                                 CarName = ca.CarName,
                                 ModelYear = ca.ModelYear,
                                 Description = ca.Description,

                             };
                return result.First();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             where ca.BrandId == brandId
                             select new CarDetailDto
                             {
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 CarName = ca.CarName,
                                 DailyPrice = ca.DailyPrice,
                                 BrandId = br.Id,
                                 ColorId = co.Id,
                                 CarId = ca.CarId,
                                 ModelYear = ca.ModelYear,
                                 Description = ca.Description,

                             };
                return result.ToList();
            }
        }
    }
}