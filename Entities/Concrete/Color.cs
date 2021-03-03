using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Color: BaseEntity,IEntity
    {
        //public int Id { get; set; }
        public string Name { get; set; }
    }
}
