using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfEducationProgramDal:EfRepositoryBase<EducationProgram,int,TobetoContext>,IEducationProgramDal
    {
        public EfEducationProgramDal(TobetoContext context):base(context)
        {
            TobetoContext _context;
        }
    }
}
