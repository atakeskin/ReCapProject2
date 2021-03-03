using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim : BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

    }
}
