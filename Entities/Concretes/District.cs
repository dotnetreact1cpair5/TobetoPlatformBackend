using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class District : Entity<int>
    {
        public int CityId { get; set; }
        public City City { get; set; }
        public string Name { get; set; }
    }
}
