using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public int BrandId { get; set; }
        public String BrandName { get; set; }
    }
}
