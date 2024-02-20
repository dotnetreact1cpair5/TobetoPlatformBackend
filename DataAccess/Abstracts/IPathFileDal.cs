using Core.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IPathFileDal : IRepository<Entities.Concretes.PathFile, int>, IAsyncRepository<Entities.Concretes.PathFile, int>
    {

    }
}
