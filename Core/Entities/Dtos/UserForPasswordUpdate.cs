using Core.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Dtos
{
    public class UserForPasswordUpdate : IDto
    {
        public string Email { get; set; }
    }
}
