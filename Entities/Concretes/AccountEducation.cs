using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountEducation:Entity<int>
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }

        //1den fazla education bilgisini accountta tuttuk, burada her bir edu için 1 status tanımı olmalı
        public int EducationStatusId { get; set; }
        public EducationStatus EducationStatus { get; set; }

        public int UniversityId { get; set; }
        public University University { get; set; }

        public int EducationProgramId { get; set; }
        public EducationProgram EducationProgram { get; set; }

        public DateTime StartYear { get; set; }
        public DateTime GraduationYear { get; set; } 
        public bool IsGraduated { get; set; }
    }
}
