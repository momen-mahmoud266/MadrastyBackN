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
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int holidaysAndFeastsId);
        Task<ServiceResponse> Delete(int holidaysAndFeastsId);
        Task<ServiceResponse> Save(HolidaysAndFeastsViewModel holidaysAndFeasts);
        Task<ServiceResponse> Update(HolidaysAndFeastsViewModel holidaysAndFeasts);
    }
}
