using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class GetListResultDetailResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int QuestionSetId { get; set; }
        public int Correct { get; set; }
        public int Incorrect { get; set; }
        public int Empty { get; set; }
        public int TotalPoint { get; set; }
        public string Status { get; set; }
    }
}
