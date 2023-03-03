using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISubjectService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int subjectId);
        Task<ServiceResponse> Delete(int subjectId);
        Task<ServiceResponse> Save(SubjectViewModel subject);
        Task<ServiceResponse> Update(SubjectViewModel subject);
        Task<ServiceResponse> GetByClassId(int classId);
        Task<ServiceResponse> GetByEmpId(int empId);
        Task<ServiceResponse> GetByDepId(int depId);
    }
}
