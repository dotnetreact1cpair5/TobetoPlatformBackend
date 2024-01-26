﻿using Business.Abstract;
using Business.Concrete;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Security.JWT;
using DataAccess.Abstracts;
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
            services.AddScoped<ICourseService, CourseManager>();
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

            // ----------------------FOR RULES-----------------------
            services.AddScoped<AccountCertificateBusinessRules>();
            services.AddScoped<AccountEducationBusinessRules>();
            services.AddScoped<AccountSocialMediaBusinessRules>();
            services.AddScoped<CityBusinessRules>();
            services.AddScoped<CountryBusinessRules>();
            services.AddScoped<EducationProgramBusinessRules>();
            services.AddScoped<AccountExperienceBusinessRules>();
            services.AddScoped<SocialMediaPlatformBusinessRules>();
            services.AddScoped<UniversityBusinessRules>();
            services.AddScoped<AccountBusinessRules>();
            services.AddScoped<SkillBusinessRules>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
