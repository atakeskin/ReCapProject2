using System;
using Core.Entities;

namespace Entities.DTOs
{
    /// <summary>
    /// Rental,Car,User
    /// </summary>
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string CarPlakaNo { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
