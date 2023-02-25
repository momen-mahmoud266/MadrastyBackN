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
    public class ActivityService
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
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivityName), Value = activity.ActivityName });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivityDepartment), Value = activity.ActivityDepartment });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivitySchoolYear), Value = activity.ActivitySchoolYear });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivitySchoolYearId), Value = activity.ActivitySchoolYearId });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivityLevel), Value = activity.ActivityLevel });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivityDate), Value = activity.ActivityDate });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivitySchoolTerm), Value = activity.ActivitySchoolTerm });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivityNotes), Value = activity.ActivityNotes });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ParentId), Value = activity.ParentId });

            var result = await _db.ExecuteNonQuery("SaveActivity", param);
            return new ServiceResponse(result);
        }

        public async Task<ServiceResponse> Update(ActivityViewModel activity)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivityId), Value = activity.ActivityId });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivityName), Value = activity.ActivityName });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivityDepartment), Value = activity.ActivityDepartment });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivitySchoolYear), Value = activity.ActivitySchoolYear });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivitySchoolYearId), Value = activity.ActivitySchoolYearId });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivityLevel), Value = activity.ActivityLevel });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivityDate), Value = activity.ActivityDate });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivitySchoolTerm), Value = activity.ActivitySchoolTerm });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ActivityNotes), Value = activity.ActivityNotes });
            param.Add(new SqlParameter { ParameterName = nameof(activity.ParentId), Value = activity.ParentId });

            var result = await _db.ExecuteNonQuery("UpdateActivity", param);
            return new ServiceResponse(result);
        }
    }
}
