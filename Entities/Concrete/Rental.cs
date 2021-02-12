using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Rental:IEntity
    {
        //Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi),
        //ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
