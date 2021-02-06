using System;
using System.Runtime.InteropServices.ComTypes;
using Core.Entities;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public DateTime ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public virtual Brand Brands { get; set; }

        public virtual Color Colors { get; set; }
    }
}
