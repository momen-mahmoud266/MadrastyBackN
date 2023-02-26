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
    public class BehaviourStatusDetailsService : IBehaviourStatusDetailsService
    {
        private readonly IDatabaseContext _db;

        public BehaviourStatusDetailsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteBehaviourStatusDetails", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetBehaviourStatusDetails");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetBehaviourStatusDetailsById", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByStudentId(int studentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(studentId), studentId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetBehaviourStatusDetailsByStudentId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByBehaviourStatusId(int behaviourStatusId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(behaviourStatusId), behaviourStatusId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetBehaviourStatusDetailsByStudentId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(BehaviourStatusDetailsViewModel behaviourStatusDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveBehaviourStatusDetails",
           _db.CreateListOfSqlParams(behaviourStatusDetails, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(BehaviourStatusDetailsViewModel behaviourStatusDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateBehaviourStatusDetails",
              _db.CreateListOfSqlParams(behaviourStatusDetails, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
