using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class University : Entity<int>
    {
        public string Name { get; set; }
        public ICollection<EducationProgram> EducationPrograms { get; set; }
    }
}
