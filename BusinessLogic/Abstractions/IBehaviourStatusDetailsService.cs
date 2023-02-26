using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IBehaviourStatusDetailsService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> Save(BehaviourStatusDetailsViewModel behaviourStatusDetails);
        Task<ServiceResponse> Update(BehaviourStatusDetailsViewModel behaviourStatusDetails);
        Task<ServiceResponse> GetByStudentId(int studentId);
        Task<ServiceResponse> GetByBehaviourStatusId(int behaviourStatusId);
    }
}
