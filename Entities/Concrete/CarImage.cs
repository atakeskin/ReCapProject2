using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class CarImage : BaseEntity,IEntity
    {
        public int CarId { get; set; }
        public string ImagePath { get; set; }
    }
}
