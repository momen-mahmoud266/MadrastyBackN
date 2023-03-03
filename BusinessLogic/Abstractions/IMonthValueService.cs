using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IMonthValueService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> Save(MonthValueViewModel monthValue);
        Task<ServiceResponse> Update(MonthValueViewModel nonthValue);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> UpdateMonthValueState(int id, int state);
        Task<ServiceResponse> GetMonthValueForDashboard();
    }
}
