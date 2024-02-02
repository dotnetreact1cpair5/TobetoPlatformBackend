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
            services.AddScoped<ICountryDal, EfCountryDal>();
            services.AddScoped<ICityDal, EfCityDal>();
            services.AddScoped<IDistrictDal, EfDistrictDal>();
            services.AddScoped<IAccountStudentClassDal, EfAccountStudentClassDal>();
            services.AddScoped<ISocialMediaPlatformDal, EfSocialMediaPlatformDal>();
            services.AddScoped<IAccountSocialMediaDal, EfAccountSocialMediaDal>();
            services.AddScoped<IEducationStatusDal, EfEducationStatusDal>();
            services.AddScoped<IUniversityDal, EfUniversityDal>();
            services.AddScoped<IEducationProgramDal, EfEducationProgramDal>();
            services.AddScoped<IAccountEducationDal, EfAccountEducationDal>();
            services.AddScoped<ISkillDal, EfSkillDal>();

            /*Course Services */
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IContentTypeDal, EfContentTypeDal>();
            services.AddScoped<ICourseContentDal, EfCourseContentDal>();
            services.AddScoped<ILessonDal, EfLessonDal>();
            services.AddScoped<ILessonStatusDal, EfLessonStatusDal>();
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICourseDetailDal, EfCourseDetailDal>();
            services.AddScoped<IAccountStudentClassDal, EfAccountStudentClassDal>();
            services.AddScoped<ICoursePageDal, EfCoursePageDal>();
            services.AddScoped<ICoursePageLessonDal, EfCoursePageLessonDal>();
            services.AddScoped<ICourseCoursePageDal, EfCourseCoursePageDal>();
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<IContentDal, EfContentDal>();
            services.AddScoped<IContentCoursePageDal, EfContentCoursePageDal>();
            services.AddScoped<ILessonFavouriteDal, EfLessonFavouriteDal>();
            services.AddScoped<ICourseFavouriteDal, EfCourseFavouriteDal>();
            services.AddScoped<ICourseCompletionDal, EfCourseCompletionDal>();
            services.AddScoped<IInstructorDal, EfInstructorDal>();
            services.AddScoped<ISessionRecordDal, EfSessionRecordDal>();

            /*User Service */
            services.AddScoped<IUserDal, EfUserDal>();

            /*PathFile Service */
            services.AddScoped<IPathFileDal, EfPathFileDal>();  

            return services;
        }
    }
}
