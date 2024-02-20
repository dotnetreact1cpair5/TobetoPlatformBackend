using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountCertificate : Entity<int>
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public string Name { get; set; } 
        //public string Path { get; set; } 
        //public Guid Key { get; set; }
    }
}
