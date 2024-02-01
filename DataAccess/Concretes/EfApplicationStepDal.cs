using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfApplicationStepDal:EfRepositoryBase<ApplicationStep,int,TobetoContext>,IApplicationStepDal
    {
        public EfApplicationStepDal(TobetoContext context):base(context)
        {
            TobetoContext _context;
        }
    }
}
