using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IMaintenanceService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int maintenanceId);
        Task<ServiceResponse> Delete(int maintenanceId);
        Task<ServiceResponse> Save(MaintenanceViewModel maintenance);
        Task<ServiceResponse> Update(MaintenanceViewModel maintenance);
    }
}
