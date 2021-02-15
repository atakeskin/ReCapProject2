using Core.Entities;
using Entities.Abstract;

namespace Entities.DTOs
{
    public class CustomerDetailDto : BaseEntity,IDto
    {
        public string UserName { get; set; }
        public string CompanyName { get; set; }
    }
}
