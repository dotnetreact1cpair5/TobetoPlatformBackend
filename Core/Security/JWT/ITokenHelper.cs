﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.JWT
{
    public interface ITokenHelper
    {
        Task<AccessToken> CreateToken(User user, IList<OperationClaim> operationClaims);


    }
}

