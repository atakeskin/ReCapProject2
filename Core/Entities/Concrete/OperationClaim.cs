using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class OperationClaim : BaseEntity, IEntity
    {
        public string Name { get; set; }
    }
}
