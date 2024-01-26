﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfSkillDal : EfRepositoryBase<Skill,int,TobetoContext>, ISkillDal
    {
        public EfSkillDal(TobetoContext context) : base(context)
        {
            TobetoContext _context;
        }
    }
}
