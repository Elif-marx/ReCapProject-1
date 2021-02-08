using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFBrandDal : EfEntityRepositoryBase <Brand,ReCapContext>, IBrandDal
    {
       
    }
}
