using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IAbsenceStatisticsService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> Save(AbsenceStatisticsViewModel absenceStatistics);
        Task<ServiceResponse> Update(AbsenceStatisticsViewModel absenceStatistics);
    }
}
