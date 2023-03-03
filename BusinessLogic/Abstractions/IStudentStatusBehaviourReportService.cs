using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IStudentStatusBehaviourReportService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int studentStatusBehaviourReportId);
        Task<ServiceResponse> Delete(int studentStatusBehaviourReportId);
        Task<ServiceResponse> Save(StudentStatusBehaviourReportViewModel studentStatusBehaviourReport);
        Task<ServiceResponse> Update(StudentStatusBehaviourReportViewModel studentStatusBehaviourReport);
    }
}
