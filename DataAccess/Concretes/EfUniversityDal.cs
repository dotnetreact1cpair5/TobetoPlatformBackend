using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfUniversityDal:EfRepositoryBase<University,int,TobetoContext>,IUniversityDal
    {
        public EfUniversityDal(TobetoContext context):base(context)
        {
            TobetoContext _context;
        }
    }
}
