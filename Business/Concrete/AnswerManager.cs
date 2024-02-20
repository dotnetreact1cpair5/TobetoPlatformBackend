using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.UpdatedResponse;
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
    public class AnswerManager : IAnswerService
    {
        IAnswerDal _answerDal;
        IMapper _mapper;

        public AnswerManager(IAnswerDal answerDal,IMapper mapper)
        {
            _answerDal = answerDal;
            _mapper = mapper;
        }

        public async Task<CreatedAnswerResponse> Add(CreateAnswerRequest createAnswerRequest)
        {
            Answer answer = _mapper.Map<Answer>(createAnswerRequest);
            var createdAnswer = await _answerDal.AddAsync(answer);
            CreatedAnswerResponse result = _mapper.Map<CreatedAnswerResponse>(createdAnswer);
            return result;
        }

        public async Task<DeletedAnswerResponse> Delete(DeleteAnswerRequest deleteAnswerRequest)
        {
            Answer answer = await _answerDal.GetAsync(a => a.Id == deleteAnswerRequest.Id);
            var deletedAnswer = await _answerDal.DeleteAsync(answer, false);
            DeletedAnswerResponse result = _mapper.Map<DeletedAnswerResponse>(deletedAnswer);
            return result;
        }

        public async Task<IPaginate<GetListAnswerResponse>> GetList(PageRequest pageRequest)
        {
            var answer = await _answerDal.GetListAsync(
                //include: a => a.Include(b => b.Country).ThenInclude(c => c.Cities).ThenInclude(d => d.Districts),
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAnswerResponse>>(answer);
            return result;
        }

        public async Task<UpdatedAnswerResponse> Update(UpdateAnswerRequest updateAnswerRequest)
        {
            Answer answer = await _answerDal.GetAsync(a => a.Id == updateAnswerRequest.Id);
            _mapper.Map(updateAnswerRequest, answer);
            var updatedAnswer = await _answerDal.UpdateAsync(answer);
            UpdatedAnswerResponse result = _mapper.Map<UpdatedAnswerResponse>(updatedAnswer);
            return result;
        }
    }
}
