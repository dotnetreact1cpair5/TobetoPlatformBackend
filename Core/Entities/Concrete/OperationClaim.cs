﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class OperationClaim : Entity<int>
    {
        public string Name { get; set; }

        //public ICollection<User> Users { get; set; }
        //public virtual UserOperationClaim UserOperationClaim { get; set; }

        //public OperationClaim()
        //{
        //}
        
        //public OperationClaim(int id, string name) : base(id)
        //{
        //    Name = name;
        //}
    }
}
