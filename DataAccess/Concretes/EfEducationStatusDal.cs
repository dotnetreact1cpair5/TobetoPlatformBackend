using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfEducationStatusDal:EfRepositoryBase<EducationStatus,int,TobetoContext>,IEducationStatusDal
    {
        public EfEducationStatusDal(TobetoContext context):base(context)
        {
            TobetoContext _context;
        }
    }
}
