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
    public class SingalIrConnectionService : ISingalIrConnectionService
    {

        private readonly IDatabaseContext _db;

        public SingalIrConnectionService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> SendNotifications(SingalIrConnectionViewModel signalIRConnection)
        {
            var dalResponse = await _db.ExecuteNonQuery("SendNotifications",
               _db.CreateListOfSqlParams(signalIRConnection, new List<string>() { "Ser","Title","Body","JobId" }));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> SendNotificationsEmails(SingalIrConnectionViewModel signalIRConnection)
        {
            var dalResponse = await _db.ExecuteNonQuery("SendNotificationsEmails",
               _db.CreateListOfSqlParams(signalIRConnection, new List<string>() { "Ser", "Title", "Body", "JobId" }));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> Save(int connectionId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(connectionId), connectionId.ToString());

            var dalResponse = await _db.ExecuteQuery("SaveSignalIRConnection", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Delete(int connectionId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(connectionId), connectionId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSignalIRConnection", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSignalIRConnections");
            return new ServiceResponse(dalResponse);
        }

      
    }
}
