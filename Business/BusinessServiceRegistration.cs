using Business.Abstract;
using Business.Concrete;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Business.Rules;
using Core.Security.JWT;
using Core.Utilities.FileUpload;
using DataAccess.Abstracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountCertificateService, AccountCertificateManager>();
            services.AddScoped<IAccountExperienceService, AccountExperienceManager>();
            services.AddScoped<IAccountEducationService, AccountEducationManager>();
            services.AddScoped<IAccountForeignLanguageService, AccountForeignLanguageManager>();
            services.AddScoped<IAccountSkillService, AccountSkillManager>();
            services.AddScoped<IAccountSocialMediaService, AccountSocialMediaManager>();
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<ICountryService, CountryManager>();
            services.AddScoped<IDistrictService, DistrictManager>();
            services.AddScoped<IEducationProgramService, EducationProgramManager>();
            services.AddScoped<IEducationStatusService, EducationStatusManager>();
            services.AddScoped<IForeignLanguageLevelService, ForeignLanguageLevelManager>();
            services.AddScoped<IForeignLanguageService, ForeignLanguageManager>();
            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<ISocialMediaPlatformService, SocialMediaPlatformManager>();
            services.AddScoped<IUniversityService, UniversityManager>();
            services.AddScoped<IUserService, UserManager>();

            /*Course Services */

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IContentService, ContentManager>();
            services.AddScoped<IContentTypeService, ContentTypeManager>();
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<ILessonService, LessonManager>();
            services.AddScoped<ILessonFavouriteService, LessonFavouriteManager>();
            services.AddScoped<ILessonStatusService, LessonStatusManager>();
            services.AddScoped<IAccountCourseService, AccountCourseManager>();
            services.AddScoped<ICourseFavouriteService, CourseFavouriteManager>();
            services.AddScoped<IInstructorService, InstructorManager>();
            services.AddScoped<ISessionRecordService, SessionRecordManager>();

            /*Application Services */
            services.AddScoped<IAccountApplicationService, AccountApplicationManager>();
            services.AddScoped<IApplicationService, ApplicationManager>();
            services.AddScoped<IApplicationStepService, ApplicationStepManager>();

            /*Announcement Services */
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementTypeService, AnnouncementTypeManager>();

            /*User Services */
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IAuthService, AuthManager>();

            /*Path Service */
            services.AddScoped<IPathFileService, PathFileManager>();
            services.AddScoped<IFileUploadAdapter, CloudinaryAdapter>();


            services.AddScoped<IOrganizationService, OrganizationManager>();
            services.AddScoped<ISurveyService, SurveyManager>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }

        public static IServiceCollection AddSubClassesOfType(this IServiceCollection services,
       Assembly assembly, Type type, Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (var item in types)
                if (addWithLifeCycle == null)
                    services.AddScoped(item);

                else
                    addWithLifeCycle(services, type);
            return services;
        }
    }
}
