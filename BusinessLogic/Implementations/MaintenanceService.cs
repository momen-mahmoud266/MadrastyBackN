using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class MaintenanceService : IMaintenanceService
    {

        private readonly IDatabaseContext _db;

        public MaintenanceService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int maintenanceId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(maintenanceId), maintenanceId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteMaintenance", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetMaintenance");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int maintenanceId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(maintenanceId), maintenanceId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetMaintenanceById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(MaintenanceViewModel maintenance)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveMaintenance",
               _db.CreateListOfSqlParams(maintenance, new List<string>() { "MaintId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(MaintenanceViewModel maintenance)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateMaintenance",
               _db.CreateListOfSqlParams(maintenance, new List<string>()));

            return new ServiceResponse(dalResponse);
        }

    }
}
