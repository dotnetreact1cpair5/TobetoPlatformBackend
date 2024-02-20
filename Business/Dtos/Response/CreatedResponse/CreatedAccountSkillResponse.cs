using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.CreatedResponse
{
    public class CreatedAccountSkillResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int SkillId { get; set; }
    }
}
