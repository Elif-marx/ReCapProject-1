using System;
using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var result = from r in reCapContext.Rentals
                             join c in reCapContext.Cars
                             on r.CarId equals c.CarId
                             join b in reCapContext.Brands
                             on c.BrandId equals b.BrandId
                             join l in reCapContext.Colors
                             on c.ColorId equals l.ColorId
                             join u in reCapContext.Users
                             on r.CustomerId equals u.UserId
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 Color = l.ColorName,
                                 ModelYear = c.ModelYear,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
//public int RentalId { get; set; }
//public string CarName { get; set; }
//public string BrandName { get; set; }
//public string Color { get; set; }
//public string ModelYear { get; set; }
//public string FirstName { get; set; }
//public string LastName { get; set; }
//public DateTime RentDate { get; set; }
//public DateTime ReturnDate { get; set; }