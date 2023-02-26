using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class BehavioralStatusService : IBehavioralStatusService
    {
        private readonly IDatabaseContext _db;

        public BehavioralStatusService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteBehavioralStatus", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetBehavioralStatus");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetBehavioralStatusById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(BehavioralStatusViewModel behavioralStatus)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveBehavioralStatus",
            _db.CreateListOfSqlParams(behavioralStatus, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(BehavioralStatusViewModel behavioralStatus)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateBehavioralStatus",
               _db.CreateListOfSqlParams(behavioralStatus, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
