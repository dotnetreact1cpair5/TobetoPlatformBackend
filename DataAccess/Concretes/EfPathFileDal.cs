using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfPathFileDal : EfRepositoryBase<Entities.Concretes.PathFile, int, TobetoContext>, IPathFileDal
    {
        public EfPathFileDal(TobetoContext context) : base(context)
        {
            TobetoContext _context;
        }
    }
}
