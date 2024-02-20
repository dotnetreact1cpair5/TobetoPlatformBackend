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
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;
        IMapper _mapper;

        public QuestionManager(IQuestionDal questionDal,IMapper mapper)
        {
            _questionDal = questionDal;
            _mapper = mapper;
        }

        public async Task<CreatedQuestionResponse> Add(CreateQuestionRequest createQuestionRequest)
        {
            Question question = _mapper.Map<Question>(createQuestionRequest);
            var createdQuestion = await _questionDal.AddAsync(question);
            CreatedQuestionResponse result = _mapper.Map<CreatedQuestionResponse>(createdQuestion);
            return result;
        }

        public async Task<DeletedQuestionResponse> Delete(DeleteQuestionRequest deleteQuestionRequest)
        {
            Question question = await _questionDal.GetAsync(a => a.Id == deleteQuestionRequest.Id);
            var deletedQuestion = await _questionDal.DeleteAsync(question, false);
            DeletedQuestionResponse result = _mapper.Map<DeletedQuestionResponse>(deletedQuestion);
            return result;
        }

        //public async Task<IPaginate<GetListQuestionResponse>> GetById(PageRequest pageRequest, int questionSetId)
        //{
        //    var question = await _questionDal.GetAsync(
        //    predicate:  q => q.QuestionSetId == questionSetId,
        //    include: a => a.Include(b => b.Answers),
        //    orderBy: a => a.OrderBy(a => a.Id),
        //    index: pageRequest.PageIndex,
        //    size: pageRequest.PageSize);
        //    var result = _mapper.Map<Paginate<GetListQuestionResponse>>(question);
        //    return result;
        //}

        public async Task<IPaginate<GetListQuestionResponse>> GetList(PageRequest pageRequest)
        {
            var question = await _questionDal.GetListAsync(
            include: a => a.Include(b => b.Answers),
            orderBy: a => a.OrderBy(a => a.Id),
            index: pageRequest.PageIndex,
            size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListQuestionResponse>>(question);
            return result;
        }

        public async Task<UpdatedQuestionResponse> Update(UpdateQuestionRequest updateQuestionRequest)
        {
            Question question = await _questionDal.GetAsync(a => a.Id == updateQuestionRequest.Id);
            _mapper.Map(updateQuestionRequest, question);
            var updatedQuestion = await _questionDal.UpdateAsync(question);
            UpdatedQuestionResponse result = _mapper.Map<UpdatedQuestionResponse>(updatedQuestion);
            return result;
        }
    }
}
