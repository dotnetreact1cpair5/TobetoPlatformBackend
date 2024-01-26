using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concrete
{
    public class SocialMediaPlatformManager : ISocialMediaPlatformService
    {
        ISocialMediaPlatformDal _socialMediaPlatformDal;
        IMapper _mapper;
        SocialMediaPlatformBusinessRules _socialMediaPlatformBusinessRules;

        public SocialMediaPlatformManager(ISocialMediaPlatformDal socialMediaPlatformDal,
        IMapper mapper, SocialMediaPlatformBusinessRules socialMediaPlatformBusinessRules)
        {
            _socialMediaPlatformDal = socialMediaPlatformDal;
            _mapper = mapper;
            _socialMediaPlatformBusinessRules = socialMediaPlatformBusinessRules;
        }

        [ValidationAspect(typeof(SocialMediaPlatformValidator))]
        public async Task<CreatedSocialMediaPlatformResponse> Add(CreateSocialMediaPlatformRequest createSocialMediaPlatformRequest)
        {
            await _socialMediaPlatformBusinessRules.SameSocialMediaName(createSocialMediaPlatformRequest.Name);
            SocialMediaPlatform socialMediaPlatform = _mapper.Map<SocialMediaPlatform>(createSocialMediaPlatformRequest);
            var createdSocialMediaPlatform = await _socialMediaPlatformDal.AddAsync(socialMediaPlatform);
            CreatedSocialMediaPlatformResponse result = _mapper.Map<CreatedSocialMediaPlatformResponse>(createdSocialMediaPlatform);
            return result;
        }

        public async Task<DeletedSocialMediaPlatformResponse> Delete(DeleteSocialMediaPlatformRequest deleteSocialMediaPlatformRequest)
        {
            SocialMediaPlatform socialMediaPlatform = await _socialMediaPlatformDal.GetAsync(smp => smp.Id == deleteSocialMediaPlatformRequest.Id);
            var deletedSocialMediaPlatform = await _socialMediaPlatformDal.DeleteAsync(socialMediaPlatform, false);
            DeletedSocialMediaPlatformResponse result = _mapper.Map<DeletedSocialMediaPlatformResponse>(deletedSocialMediaPlatform);
            return result;
        }

        public async Task<IPaginate<GetListSocialMediaPlatformResponse>> GetListSocialMediaPlatform(PageRequest pageRequest)
        {
            var socialMediaPlatform = await _socialMediaPlatformDal.GetListAsync(
                orderBy: s => s.OrderBy(s => s.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListSocialMediaPlatformResponse>>(socialMediaPlatform);
            return result;
        }

        public async Task<UpdatedSocialMediaPlatformResponse> Update(UpdateSocialMediaPlatformRequest updateSocialMediaPlatformRequest)
        {
            SocialMediaPlatform socialMediaPlatform = await _socialMediaPlatformDal.GetAsync(smp => smp.Id == updateSocialMediaPlatformRequest.Id);
            _mapper.Map(updateSocialMediaPlatformRequest, socialMediaPlatform);
            var updatedSocialMediaPlatform = await _socialMediaPlatformDal.UpdateAsync(socialMediaPlatform);
            UpdatedSocialMediaPlatformResponse result = _mapper.Map<UpdatedSocialMediaPlatformResponse>(updatedSocialMediaPlatform);
            return result;
        }
    }
}
