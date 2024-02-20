using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class PathFile : Entity<int>
    {
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public string Description { get; set; }
    }
}
