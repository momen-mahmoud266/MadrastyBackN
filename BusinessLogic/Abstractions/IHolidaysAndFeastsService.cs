using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IHolidaysAndFeastsService
    {
        Task<ServiceResponse> GetHolidaysAndFeasts();
        Task<ServiceResponse> GetHolidaysAndFeastsById(int holidaysAndFeastsId);
        Task<ServiceResponse> DeleteHolidaysAndFeasts(int holidaysAndFeastsId);
        Task<ServiceResponse> SaveHolidaysAndFeasts(HolidaysAndFeastsViewModel holidaysAndFeasts);
        Task<ServiceResponse> UpdateHolidaysAndFeasts(HolidaysAndFeastsViewModel holidaysAndFeasts);
    }
}
