using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IWorkPlanService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int workPlanId);
        Task<ServiceResponse> Delete(int workPlanId);
        Task<ServiceResponse> Save(WorkPlanViewModel workPlan);
        Task<ServiceResponse> Update(WorkPlanViewModel workPlan);
    }
}
