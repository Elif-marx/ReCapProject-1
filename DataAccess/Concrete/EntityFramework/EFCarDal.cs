using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System.Collections.Generic;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var result = from c in reCapContext.Cars
                             join b in reCapContext.Brands
                             on c.BrandId equals b.BrandId
                             join l in reCapContext.Colors
                             on c.ColorId equals l.ColorId
                             select new ProductDetailDto
                             {
                                 Id = c.Id, BrandName = b.BrandName, ColorName = l.ColorName, DailyPrice = c.DailyPrice, ModelYear = c.ModelYear, Description = c.Description
                             };
                return result.ToList();
            }
            
        }
    }
}
