using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository <Car>
    {
        List<CarDetailDto> GetCarDetails();
        CarDetailDto GetCarDetailsById(int id);
        List<CarDetailDto> GetCarDetailsByBrandId(int colorId);
    }
}
