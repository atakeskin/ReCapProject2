using System;
using Core.Entities;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Car : BaseEntity,IEntity
    {
        //public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string Name { get; set; }
        public string PlakaNo { get; set; }
        public DateTime? ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
