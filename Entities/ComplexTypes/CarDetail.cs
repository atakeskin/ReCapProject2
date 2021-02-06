using System;
using Core.Entities;

namespace Entities.ComplexTypes
{
    public class CarDetail : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public DateTime ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
