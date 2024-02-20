using Core.Entities.Concrete;
using Core.Security.JWT;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess.Context
{
    public class TobetoContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountAnswer> AccountAnswers { get; set; }
        public DbSet<AccountQuestionSet> AccountQuestionSets { get; set; }
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
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionSet> QuestionSets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }

        /*User */
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }


        /*Course */
        public DbSet<AccountCourse> AccountCourses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<CourseCompletion> CourseCompletions { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonStatus> LessonStatuses { get; set; }
        public DbSet<LessonFavourite> LessonFavourites { get; set; }
        public DbSet<CourseTimeSpent> CourseTimeSpents { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<CourseFavourite> CourseFavourites { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<SessionRecord> SessionRecords { get; set; }

        /*PathFile */
        public DbSet<PathFile> PathFiles { get; set; }

        /*Organization */
        public DbSet<Organization> Organizations { get; set; }

        /*Survey */
        public DbSet<Survey> Surveys { get; set; }

        /*Application */
        public DbSet<AccountApplication> AccountApplications { get; set; }
        public DbSet<Entities.Concretes.Application> Applications {  get; set; }  
        public DbSet<ApplicationStep> ApplicationSteps { get; set; }

        /*Announcement */
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<AnnouncementType> AnnouncementTypes { get; set; }

        public TobetoContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
           // Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
