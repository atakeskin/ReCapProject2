using Core.Entities;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand : BaseEntity,IEntity
    {
        //public int Id { get; set; }
        public string Name { get; set; }
    }
}
