using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IEmployeeService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> Save(EmployeeViewModel employee);
        Task<ServiceResponse> Update(EmployeeViewModel employee);
        Task<ServiceResponse> GetByJobId(int jobId);
        Task<ServiceResponse> GetBySubjectId(int subjectId);
        Task<ServiceResponse> GetBySubjectIdAndValidation(int subjectId, string start);
    }
}
}
