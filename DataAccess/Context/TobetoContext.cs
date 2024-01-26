using Core.Entities.Concrete;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class TobetoContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountCertificate> AccountCertificates { get; set; }
        public DbSet<AccountEducation> AccountEducations { get; set; }
        public DbSet<AccountExperience> AccountExperiences { get; set; }
        public DbSet<AccountForeignLanguage> AccountForeignLanguages { get; set; }
        public DbSet<AccountSkill> AccountSkills { get; set; }
        public DbSet<AccountSocialMedia> AccountSocialMedias { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<EducationProgram> EducationPrograms { get; set; }
        public DbSet<EducationStatus> EducationStatuses { get; set; }
        public DbSet<ForeignLanguage> ForeignLanguages { get; set; }
        public DbSet<ForeignLanguageLevel> ForeignLanguagesLevels { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMediaPlatform> SocialMediaPlatforms { get; set; }
        public DbSet<University> Universities { get; set; }

        public TobetoContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
