
using Core.DataAccess.Repositories;
using Core.Entities.Concrete;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{


    public interface IUserDal: IRepository<User, int>, IAsyncRepository<User, int>
    {
      List<Core.Entities.Concrete.OperationClaim> GetClaims(User user);

    }
}
