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
    public class ObservationService : IObservationService
    {
        private readonly IDatabaseContext _db;

        public ObservationService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteObservation", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetObsrvations");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetObsrvationById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(ObservationViewModel observation)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveObservation",
               _db.CreateListOfSqlParams(observation, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(ObservationViewModel observation)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateObservation",
               _db.CreateListOfSqlParams(observation, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
