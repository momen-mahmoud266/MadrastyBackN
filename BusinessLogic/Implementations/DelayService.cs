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
    public class DelayService
    {
        private readonly IDatabaseContext _db;

        public DelayService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteDelay", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetDelays");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetDelayById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(DelayViewModel delay)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveDelay",
               _db.CreateListOfSqlParams(delay, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(DelayViewModel delay)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateDelay",
               _db.CreateListOfSqlParams(delay, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
