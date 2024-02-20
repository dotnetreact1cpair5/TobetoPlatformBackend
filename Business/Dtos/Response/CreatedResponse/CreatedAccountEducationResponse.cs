﻿using Entities.Concretes;

namespace Business.Dtos.Response
{
    public class CreatedAccountEducationResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int EducationStatusId { get; set; }
        public int UniversityId { get; set; }
        public int EducationProgramId { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime GraduationYear { get; set; }
        public bool IsGraduated { get; set; }        
        public int UniversityId { get; set; }
        public int EducationProgramId { get; set; }      
        public int EducationStatusId { get; set; }
    }
}
