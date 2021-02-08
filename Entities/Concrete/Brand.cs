using core.Entities;
using System;


namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public int BrandId { get; set; }
        public String BrandName { get; set; }
    }
}
