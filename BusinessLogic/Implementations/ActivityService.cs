using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class ActivityService : IActivityService
    {
        private readonly IDatabaseContext _db;

        public ActivityService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int activityId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(activityId), activityId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteActivity", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetActivities");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int activityId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(activityId), activityId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetActivityById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(ActivityViewModel activity)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveActivity",
              _db.CreateListOfSqlParams(activity, new List<string>() { "ActivityId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(ActivityViewModel activity)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateActivity",
               _db.CreateListOfSqlParams(activity, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
