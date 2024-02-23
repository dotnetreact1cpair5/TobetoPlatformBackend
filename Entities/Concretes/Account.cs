using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{

    public class Account : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public District District { get; set; }
        public int DistrictId { get; set; }
        public Country Country { get; set; }

        //account configuration alanında usera ait kodlar yazıldıgından buraya da program hata vermesın dıye eklendı.Bir kullanım durumu yok 
        public int UserId { get; set; }
        public User? User { get; set; }


        public ICollection<AccountExperience> AccountExperiences { get; set; }
        public ICollection<AccountEducation> AccountEducations { get; set; }
        public ICollection<AccountSkill> AccountSkills { get; set; }
        public ICollection<AccountCertificate> AccountCertificates { get; set; }
        public ICollection<AccountSocialMedia> AccountSocialMedias { get; set; }
        public ICollection<AccountForeignLanguage> AccountForeignLanguages { get; set; }
        public ICollection<AccountAnswer> AccountAnswers { get; set; }
        public ICollection<AccountQuestionSet> AccountQuestionSets { get; set; }
    }
}
