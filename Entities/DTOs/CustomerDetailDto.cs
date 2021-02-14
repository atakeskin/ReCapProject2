using Core.Entities;

namespace Entities.DTOs
{
    public class CustomerDetailDto : IDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
    }
}
