using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public class SocialWorkerService
    {
        private readonly IDatabaseContext _db;
        public SocialWorkerService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int socialWorkerId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(socialWorkerId), socialWorkerId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSocialWorker", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSocialWorkers");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int socialWorkerId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(socialWorkerId), socialWorkerId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSocialWorkerById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SocialWorkerViewModel socialWorker)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSocialWorker",
               _db.CreateListOfSqlParams(socialWorker, new List<string>() { "SocialId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SocialWorkerViewModel socialWorker)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSocialWorker",
               _db.CreateListOfSqlParams(socialWorker, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
