using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TobetoContext>(options => options.UseSqlServer(configuration.GetConnectionString("Tobeto")));


            services.AddScoped<ICountryDal, EfCountryDal>();
            services.AddScoped<ICityDal, EfCityDal>();
            services.AddScoped<IDistrictDal, EfDistrictDal>();
            services.AddScoped<ISocialMediaPlatformDal, EfSocialMediaPlatformDal>();
            services.AddScoped<IAccountSocialMediaDal, EfAccountSocialMediaDal>();
            services.AddScoped<IEducationStatusDal, EfEducationStatusDal>();
            services.AddScoped<IUniversityDal, EfUniversityDal>();
            services.AddScoped<IEducationProgramDal, EfEducationProgramDal>();
            services.AddScoped<IAccountEducationDal, EfAccountEducationDal>();
            services.AddScoped<IAccountSkillDal, EfAccountSkillDal>();
            services.AddScoped<ISkillDal, EfSkillDal>();
            services.AddScoped<IAccountDal, EfAccountDal>();
            services.AddScoped<IForeignLanguageDal, EfForeignLanguageDal>();
            services.AddScoped<IForeignLanguageLevelDal, EfForeignLanguageLevelDal>();
            services.AddScoped<IAccountForeignLanguageDal, EfAccountForeignLanguageDal>();
            services.AddScoped<IAccountCertificateDal, EfAccountCertificateDal>();
            services.AddScoped<IAccountExperienceDal, EfAccountExperienceDal>();

            /*Course Services */
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IContentTypeDal, EfContentTypeDal>();
            services.AddScoped<ICourseContentDal, EfCourseContentDal>();
            services.AddScoped<ILessonDal, EfLessonDal>();
            services.AddScoped<ILessonStatuDal, EfLessonStatuDal>();
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICourseDetailDal, EfCourseDetailDal>();
            services.AddScoped<IAccountCourseDal, EfAccountCourseDal>();
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<IContentDal, EfContentDal>();
            services.AddScoped<IFavouriteDal, EfFavouriteDal>();
            services.AddScoped<ICourseCompletionDal, EfCourseCompletionDal>();
            services.AddScoped<ICourseTimeSpentDal, EfCourseTimeSpentDal>();
            services.AddScoped<IInstructorDal, EfInstructorDal>();
            services.AddScoped<ISessionRecordDal, EfSessionRecordDal>();

            /*Exam/Test Service */
            services.AddScoped<IAccountAnswerDal, EfAccountAnswerDal>();
            services.AddScoped<IAccountQuestionSetDal, EfAccountQuestionSetDal>();
            services.AddScoped<IAnswerDal, EfAnswerDal>();
            services.AddScoped<IQuestionDal, EfQuestionDal>();
            services.AddScoped<IQuestionSetDal, EfQuestionSetDal>();

            /*User Service */
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IOperationClaimDal, EfOperationClaimDal>();
            services.AddScoped<IUserOperationClaimDal, EfUserOperationClaimDal>();

            /*PathFile Service */
            services.AddScoped<IPathFileDal, EfPathFileDal>();

            /*Application Service */
            services.AddScoped<IAccountApplicationDal, EfAccountApplicationDal>();
            services.AddScoped<IApplicationDal, EfApplicationDal>();
            services.AddScoped<IApplicationStepDal, EfApplicationStepDal>();

            /*Announcement,Survey,Organization Service */
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementTypeDal, EfAnnouncementTypeDal>();
            services.AddScoped<ISurveyDal, EfSurveyDal>();
            services.AddScoped<IOrganizationDal, EfOrganizationDal>();

            return services;
        }
    }
}
