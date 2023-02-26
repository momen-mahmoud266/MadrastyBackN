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
    public class BehaviourStatusService : IBehaviourStatusService
    {
        private readonly IDatabaseContext _db;

        public BehaviourStatusService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteBehaviourStatus", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetBehabioursStatus");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetBehaviourStatusById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(BehaviourStatusViewModel behaviourStatus)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveBehaviourStatus",
                _db.CreateListOfSqlParams(behaviourStatus, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(BehaviourStatusViewModel behaviourStatus)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateBehaviourStatus",
              _db.CreateListOfSqlParams(behaviourStatus, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
