using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfAccountSocialMediaDal:EfRepositoryBase<AccountSocialMedia,int,TobetoContext>,IAccountSocialMediaDal
    {
        public EfAccountSocialMediaDal(TobetoContext context):base(context)
        {
            TobetoContext _context;
        }
    }
}
