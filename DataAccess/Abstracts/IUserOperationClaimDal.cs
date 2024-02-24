using Core.DataAccess.Repositories;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IUserOperationClaimDal : IRepository<UserOperationClaim, int>, IAsyncRepository<UserOperationClaim, int>
    {
    }
}
