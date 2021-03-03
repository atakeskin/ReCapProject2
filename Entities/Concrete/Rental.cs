using System;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Rental : BaseEntity,IEntity
    {
        //public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
