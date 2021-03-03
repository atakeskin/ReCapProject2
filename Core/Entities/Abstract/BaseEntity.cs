using System;

namespace Core.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
