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
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class QuestionSetManager : IQuestionSetService
    {
        IQuestionSetDal _questionSetDal;
        IMapper _mapper;

        public QuestionSetManager(IQuestionSetDal questionSetDal, IMapper mapper)
        {
            _questionSetDal = questionSetDal;
            _mapper = mapper;
        }

        public async Task<CreatedQuestionSetResponse> Add(CreateQuestionSetRequest createQuestionSetRequest)
        {
            QuestionSet questionSet = _mapper.Map<QuestionSet>(createQuestionSetRequest);
            var createdQuestionSet = await _questionSetDal.AddAsync(questionSet);
            CreatedQuestionSetResponse result = _mapper.Map<CreatedQuestionSetResponse>(createdQuestionSet);
            return result;
        }

        public async Task<DeletedQuestionSetResponse> Delete(DeleteQuestionSetRequest deleteQuestionSetRequest)
        {
            QuestionSet questionSet = await _questionSetDal.GetAsync(a => a.Id == deleteQuestionSetRequest.Id);
            var deletedQuestionSet = await _questionSetDal.DeleteAsync(questionSet, false);
            DeletedQuestionSetResponse result = _mapper.Map<DeletedQuestionSetResponse>(deletedQuestionSet);
            return result;
        }

        public async Task<IPaginate<GetListQuestionSetResponse>> GetList(PageRequest pageRequest)
        {
            var questionSet = await _questionSetDal.GetListAsync(
            include: a => a.Include(b => b.Questions).ThenInclude(c=>c.Answers),
            orderBy: a => a.OrderBy(a => a.Id),
            index: pageRequest.PageIndex,
            size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListQuestionSetResponse>>(questionSet);
            return result;
        }

        public async Task<UpdatedQuestionSetResponse> Update(UpdateQuestionSetRequest updateQuestionSetRequest)
        {
            QuestionSet questionSet = await _questionSetDal.GetAsync(a => a.Id == updateQuestionSetRequest.Id);
            _mapper.Map(updateQuestionSetRequest, questionSet);
            var updatedQuestionSet = await _questionSetDal.UpdateAsync(questionSet);
            UpdatedQuestionSetResponse result = _mapper.Map<UpdatedQuestionSetResponse>(updatedQuestionSet);
            return result;
        }
    }
}
