using System;
using Core.Entities;

namespace Entities.DTOs
{
    /// <summary>
    /// Arabaları şu bilgiler olacak şekilde listeleyiniz.
    /// CarName, BrandName, ColorName, DailyPrice.
    /// (İpucu : IDto oluşturup 3 tabloya join yazınız)
    /// </summary>
    public class CarDetailDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PlakaNo { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public DateTime ModelYear { get; set; }
    }
}
