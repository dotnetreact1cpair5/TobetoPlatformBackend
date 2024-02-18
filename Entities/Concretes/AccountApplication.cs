using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountApplication : Entity<int>
    {
        public int? UserId { get; set; }
        public int ApplicationId { get; set; }
        public string Description { get; set; }
        public User? User { get; set; }
        public Application? Application { get; set; }

    }
}
