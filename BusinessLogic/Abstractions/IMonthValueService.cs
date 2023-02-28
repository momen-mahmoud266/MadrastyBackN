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
        Task<ServiceResponse> GetMonthValue();
        Task<ServiceResponse> GetMonthValueWithId(int id);
        Task<ServiceResponse> SaveMonthValue(MonthValueViewModel monthValue);
        Task<ServiceResponse> UpdateMonthValue(MonthValueViewModel nonthValue);
        Task<ServiceResponse> DeleteFromMonthValue(int id);
        Task<ServiceResponse> UpdateMonthValueState(int id, int state);
        Task<ServiceResponse> GetMonthValueForDashboard();
    }
}
