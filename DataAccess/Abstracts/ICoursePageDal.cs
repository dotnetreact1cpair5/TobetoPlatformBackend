using Core.DataAccess.Repositories;
using DataAccess.Context;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICoursePageDal : IRepository<CoursePage, int>, IAsyncRepository<CoursePage, int>
    {
    }

}
