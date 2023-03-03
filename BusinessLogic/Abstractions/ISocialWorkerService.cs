using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISocialWorkerService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int socialWorkerId);
        Task<ServiceResponse> Delete(int socialWorkerId);
        Task<ServiceResponse> Save(SocialWorkerViewModel socialWorker);
        Task<ServiceResponse> Update(SocialWorkerViewModel socialWorker);
    }
}
