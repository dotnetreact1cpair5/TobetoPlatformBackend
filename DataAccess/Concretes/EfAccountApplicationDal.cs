using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfAccountApplicationDal:EfRepositoryBase<AccountApplication,int,TobetoContext>,IAccountApplicationDal
    {
        public EfAccountApplicationDal(TobetoContext context):base(context)
        {
            TobetoContext _context;
        }
    }
}
