using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.DeleteRequest
{
    public class DeleteOperationClaimRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
