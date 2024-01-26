using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim : Entity<int>
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

       // public virtual ICollection<User> Users { get; set; }
       // public virtual ICollection<OperationClaim> OperationClaims { get; set; }

        //public UserOperationClaim()
        //{
        //}

        //public UserOperationClaim(int id, int userId, int operationClaimId) : base(id)
        //{
        //    UserId = userId;
        //    OperationClaimId = operationClaimId;
        //}
    }
}
