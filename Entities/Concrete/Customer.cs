using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        //Customers-->UserId,CompanyName
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
