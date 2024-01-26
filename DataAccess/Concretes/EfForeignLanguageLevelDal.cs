using Core.DataAccess.Dynamic;
using Core.DataAccess.Paging;
using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfForeignLanguageLevelDal : EfRepositoryBase<ForeignLanguageLevel, int, TobetoContext>, IForeignLanguageLevelDal
    {
        public EfForeignLanguageLevelDal(TobetoContext context) : base(context)
        {
            TobetoContext _context;
        }
    }
}
