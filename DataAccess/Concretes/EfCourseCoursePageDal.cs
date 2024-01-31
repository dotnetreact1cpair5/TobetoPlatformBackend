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
    public class EfCourseCoursePageDal : EfRepositoryBase<CourseCoursePage, int, TobetoContext>, ICourseCoursePageDal
    {
        public EfCourseCoursePageDal(TobetoContext context) : base(context)
        {
            TobetoContext _context;
        }
    }




}
