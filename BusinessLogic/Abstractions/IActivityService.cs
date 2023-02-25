using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IActivityService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int activityId);
        Task<ServiceResponse> Delete(int activityId);
        Task<ServiceResponse> Save(ActivityViewModel activity);
        Task<ServiceResponse> Update(ActivityViewModel activity);
    }
}
