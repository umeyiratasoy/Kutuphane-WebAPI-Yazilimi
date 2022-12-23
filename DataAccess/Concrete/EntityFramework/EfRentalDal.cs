using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from ca in context.Cars
                             join b in context.Brands
                             on ca.BrandId equals b.Id
                             join re in context.Rentals
                             on ca.CarId equals re.CarId
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             from u in context.Users
                             join cu in context.Customers
                             on u.Id equals cu.UserId
                             from ren in context.Rentals
                             join cus in context.Customers
                             on ren.CustomerId equals cus.CustomerId

                             select new RentalDetailDto
                             {
                                 RentalId = re.RentalId,
                                 CarId = ca.CarId,
                                 CustomerId = cus.CustomerId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 BrandName = b.BrandName,
                                 Description = ca.Description,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate
                             };
                return result.ToList();

            }
        }
    }
}
