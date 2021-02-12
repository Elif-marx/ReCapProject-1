using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFUserDal : EfEntityRepositoryBase<User, ReCapContext>, IUserDal
    {
        
    }
}
