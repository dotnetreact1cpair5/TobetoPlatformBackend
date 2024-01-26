using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfAccountEducationDal:EfRepositoryBase<AccountEducation,int,TobetoContext>,IAccountEducationDal
    {
        public EfAccountEducationDal(TobetoContext context):base(context)
        {
            TobetoContext _context;
        }
    }
}
