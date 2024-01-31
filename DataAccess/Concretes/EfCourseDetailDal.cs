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
    public class EfCourseDetailDal : EfRepositoryBase<CourseTimeSpent, int, TobetoContext>, ICourseDetailDal
    {
        public EfCourseDetailDal(TobetoContext context) : base(context)
        {
            TobetoContext _context;
        }
    }
}
