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
        Task<ServiceResponse> GetMaintenance();
        Task<ServiceResponse> GetMaintenanceById(int maintenanceId);
        Task<ServiceResponse> DeleteMaintenance(int maintenanceId);
        Task<ServiceResponse> SaveMaintenance(MaintenanceViewModel maintenance);
        Task<ServiceResponse> UpdateMaintenance(MaintenanceViewModel maintenance);
    }
}
