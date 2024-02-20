using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfAnswerDal : EfRepositoryBase<Answer, int, TobetoContext>, IAnswerDal
    {
        public EfAnswerDal(TobetoContext context) : base(context)
        {
            TobetoContext _context;
        }
    }
}
