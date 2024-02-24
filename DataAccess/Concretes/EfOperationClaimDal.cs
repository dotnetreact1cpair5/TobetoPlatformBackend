using Core.DataAccess.Repositories;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfOperationClaimDal : EfRepositoryBase<OperationClaim, int, TobetoContext>, IOperationClaimDal
    {
        public EfOperationClaimDal(TobetoContext context) : base(context)
        {
            TobetoContext _context;
        }
    }


}
