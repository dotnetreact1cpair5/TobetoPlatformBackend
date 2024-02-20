using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;
        IMapper _mapper;
        SkillBusinessRules _skillBusinessRules;

        public SkillManager(ISkillDal skillDal, IMapper mapper, SkillBusinessRules skillBusinessRules)
        {
            _skillDal = skillDal;
            _mapper = mapper;
            _skillBusinessRules = skillBusinessRules;
        }

        [ValidationAspect(typeof(SkillValidator))]
        public async Task<CreatedSkillsResponse> Add(CreateSkillRequest createSkillRequest)
        {
            await _skillBusinessRules.SameSkillName(createSkillRequest.Name);
            Skill skill = _mapper.Map<Skill>(createSkillRequest);
            var createdSkill = await _skillDal.AddAsync(skill);
            CreatedSkillsResponse result = _mapper.Map<CreatedSkillsResponse>(createdSkill);
            return result;
        }

        public async Task<DeletedSkillsResponse> Delete(DeleteSkillRequest deleteSkillRequest)
        {
            Skill skill = await _skillDal.GetAsync(s=>s.Id==deleteSkillRequest.Id);
            var deletedSkill = await _skillDal.DeleteAsync(skill, false);
            DeletedSkillsResponse result = _mapper.Map<DeletedSkillsResponse>(deletedSkill);
            return result;
        }

        public async Task<IPaginate<GetListSkillsResponse>> GetListSkillInformation(PageRequest pageRequest)
        {
            var skill = await _skillDal.GetListAsync(
                orderBy: s => s.OrderBy(s => s.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListSkillsResponse>>(skill);
            return result;
        }

        public async Task<UpdatedSkillsResponse> Update(UpdateSkillRequest updateSkillRequest)
        {
            Skill skill = await _skillDal.GetAsync(s=>s.Id==updateSkillRequest.Id);
            _mapper.Map(updateSkillRequest,skill);
            var updatedSkill = await _skillDal.UpdateAsync(skill);
            UpdatedSkillsResponse result = _mapper.Map<UpdatedSkillsResponse>(updatedSkill);
            return result;
        }
    }
}
