using System;

namespace Entities.Abstract
{
    /// <summary>
    /// Entity için temel sınıfdır.
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
