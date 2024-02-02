using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Organization : Entity<int>
    {
        public int DistrictId { get; set; }

        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        public ICollection<Lesson>? Lessons { get; set; }
        public ICollection<Course>? Courses { get; set; }
        public ICollection<Application>? Applications { get; set; }
        public ICollection<Announcement>? Announcements { get; set; }
    }
}
