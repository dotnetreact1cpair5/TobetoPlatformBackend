using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concrete
{
    public class AccountEducationManager : IAccountEducationService
    {
        IAccountEducationDal _accountEducationDal;
        IMapper _mapper;
        AccountEducationBusinessRules _accountEducationBusinessRules;

        public AccountEducationManager(IAccountEducationDal accountEducationDal,
        IMapper mapper,
        AccountEducationBusinessRules accountEducationBusinessRules)
        {
            _accountEducationDal = accountEducationDal;
            _mapper = mapper;
            _accountEducationBusinessRules = accountEducationBusinessRules;
        }

        [ValidationAspect(typeof(AccountEducationValidator))]
        public async Task<CreatedAccountEducationResponse> Add(CreateAccountEducationRequest createAccountEducationRequest)
        {
            AccountEducation accountEducation = _mapper.Map<AccountEducation>(createAccountEducationRequest);
            var createdAccountEducation = await _accountEducationDal.AddAsync(accountEducation);
            CreatedAccountEducationResponse result = _mapper.Map<CreatedAccountEducationResponse>(createdAccountEducation);
            return result;
        }

        public async Task<DeletedAccountEducationResponse> Delete(DeleteAccountEducationRequest deleteAccountEducationRequest)
        {
            AccountEducation accountEducation = await _accountEducationDal.GetAsync(a => a.Id == deleteAccountEducationRequest.Id);
            var deletedAccountEducation = await _accountEducationDal.DeleteAsync(accountEducation, false);
            DeletedAccountEducationResponse result = _mapper.Map<DeletedAccountEducationResponse>(deletedAccountEducation);
            return result;
        }

        public async Task<IPaginate<GetListAccountEducationResponse>> GetListAccountEducation(PageRequest pageRequest)
        {
            var accountEducation = await _accountEducationDal.GetListAsync(
                orderBy: a => a.OrderBy(a => a.UniversityId),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountEducationResponse>>(accountEducation);
            return result;
        }

        public async Task<UpdatedAccountEducationResponse> Update(UpdateAccountEducationRequest updateAccountEducationRequest)
        {
            AccountEducation accountEducation = await _accountEducationDal.GetAsync(a => a.Id == updateAccountEducationRequest.Id);
            _mapper.Map(updateAccountEducationRequest, accountEducation);
            var updatedAccountEducation = await _accountEducationDal.UpdateAsync(accountEducation);
            UpdatedAccountEducationResponse result = _mapper.Map<UpdatedAccountEducationResponse>(updatedAccountEducation);
            return result;
        }
    }
}
