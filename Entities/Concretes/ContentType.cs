using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{

    public class ContentType : Entity<int>
    {
        public string Name { get; set; }

        public ICollection<Course>? Courses { get; set; }
        public ICollection<Lesson>? Lessons { get; set; }

    }
}