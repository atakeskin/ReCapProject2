using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
    public class Color: IEntity
    {
        //public Color()
        //{
        //    Colors = new HashSet<Color>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        //public virtual ICollection<Color> Colors { get; set; }
    }
}
