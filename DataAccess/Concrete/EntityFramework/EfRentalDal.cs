using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RantACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RantACarContext context = new RantACarContext())
            {
                var result = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars on r.CarId equals c.CarId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             join cu in context.Customers on r.CustomerId equals cu.CustomerId
                             join u in context.Users on cu.CustomerId equals u.Id
                             select new RentalDetailDto
                             {
                                 RentalId=r.RentalId,
                                 BrandName=b.BrandName,
                                 ColorName=co.ColorName,
                                 DailyPrice=c.DailyPrice,
                                 Description=c.Description,
                                 FirstName=u.FirstName,
                                 LastName=u.LastName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate,
                                 
                             };
                return result.ToList();

            }
        }
    }
}
