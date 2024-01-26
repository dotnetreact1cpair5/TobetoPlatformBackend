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
    public class UniversityManager : IUniversityService
    {
        IUniversityDal _universityDal;
        IMapper _mapper;
        UniversityBusinessRules _universityBusinessRules;

        public UniversityManager(IUniversityDal universityDal,
        IMapper mapper,
        UniversityBusinessRules universityBusinessRules)
        {
            _universityDal = universityDal;
            _mapper = mapper;
            _universityBusinessRules = universityBusinessRules;
        }

        [ValidationAspect(typeof(UniversityValidator))]
        public async Task<CreatedUniversityResponse> Add(CreateUniversityRequest createUniversityRequest)
        {
            await _universityBusinessRules.SameUniversityName(createUniversityRequest.Name);
            University university = _mapper.Map<University>(createUniversityRequest);
            var createdUniversity = await _universityDal.AddAsync(university);
            CreatedUniversityResponse result = _mapper.Map<CreatedUniversityResponse>(createdUniversity);
            return result;
        }

        public async Task<DeletedUniversityResponse> Delete(DeleteUniversityRequest deleteUniversityRequest)
        {
            University university = await _universityDal.GetAsync(u => u.Id == deleteUniversityRequest.Id);
            var deletedUniversity = await _universityDal.DeleteAsync(university, false);
            DeletedUniversityResponse result = _mapper.Map<DeletedUniversityResponse>(deletedUniversity);
            return result;
        }

        public async Task<IPaginate<GetListUniversityResponse>> GetListUniversity(PageRequest pageRequest)
        {
            var university = await _universityDal.GetListAsync(orderBy: u => u.OrderBy(u => u.Name),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListUniversityResponse>>(university);
            return result;
        }

        public async Task<UpdatedUniversityResponse> Update(UpdateUniversityRequest updateUniversityRequest)
        {
            University university = await _universityDal.GetAsync(u => u.Id == updateUniversityRequest.Id);
            _mapper.Map(updateUniversityRequest, university);
            var updatedUniversity = await _universityDal.UpdateAsync(university);
            UpdatedUniversityResponse result = _mapper.Map<UpdatedUniversityResponse>(updatedUniversity);
            return result;
        }
    }
}
