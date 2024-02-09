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

        /*User & Claim Field*/
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
     

        /*Course Tables Field*/
        public DbSet<ClassCourse> ClassCourses { get; set; }
        public DbSet<AccountStudentClass> AccountStudentClasses { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<CourseCompletion> CourseCompletions { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonStatus> LessonStatuses { get; set; }
        public DbSet<LessonFavourite> LessonFavourites { get; set; }
        public DbSet<CoursePage> CoursePages { get; set; }
        public DbSet<CoursePageLesson> CoursePageLessons { get; set; }
        public DbSet<CourseCoursePage> CourseCoursePages { get; set; }
        public DbSet<ContentCoursePage> ContentCoursePages { get; set; }
        public DbSet<CourseTimeSpent> CourseTimeSpents { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<CourseFavourite> CourseFavourites { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<SessionRecord> SessionRecords { get; set; }

        /*PathFile Table Field*/
        public DbSet<PathFile> PathFiles { get; set; }

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
