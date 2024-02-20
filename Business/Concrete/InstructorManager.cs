using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {

        IInstructorDal _instructorDal;
        IMapper _mapper;
        public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;
        }

        public async Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest)
        {
            Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
            var createdInstructor = await _instructorDal.AddAsync(instructor);
            CreatedInstructorResponse result = _mapper.Map<CreatedInstructorResponse>(createdInstructor);
            return result;
        }

        public async Task<DeletedInstructorResponse> Delete(DeleteInstructorRequest deleteInstructorRequest)
        {
            Instructor instructor = await _instructorDal.GetAsync(predicate: a => a.Id == deleteInstructorRequest.Id);
            var deletedInstructor = await _instructorDal.DeleteAsync(instructor, false);
            DeletedInstructorResponse result = _mapper.Map<DeletedInstructorResponse>(deletedInstructor);
            return result;
        }

        public async Task<GetListInstructorResponse> GetById(int InstructorId)
        {
            var instructor = await _instructorDal.GetAsync(predicate: a => a.Id == InstructorId);
            var result = _mapper.Map<GetListInstructorResponse>(instructor);
            return result;
        }

        public async Task<IPaginate<GetListInstructorResponse>> GetListInstructor()
        {
            var instructor = await _instructorDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListInstructorResponse>>(instructor);
            return result;
        }

        public async Task<UpdatedInstructorResponse> Update(UpdateInstructorRequest updateInstructorRequest)
        {
            Instructor instructor = _mapper.Map<Instructor>(updateInstructorRequest);
            var updatedInstructor = await _instructorDal.UpdateAsync(instructor);
            UpdatedInstructorResponse result = _mapper.Map<UpdatedInstructorResponse>(updatedInstructor);
            return result;
        }

    }



}
