using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public Brand()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
