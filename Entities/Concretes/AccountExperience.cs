using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountExperience : Entity<int>
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Sector { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string JobDescription { get; set; }
    }
}
