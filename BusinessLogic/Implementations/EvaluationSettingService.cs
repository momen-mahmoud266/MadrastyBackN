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
    public class EvaluationSettingService : IEvaluationSettingsService
    {
        private readonly IDatabaseContext _db;

        public EvaluationSettingService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteEvaluationSettings", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetEvaluationSettings");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetEvaluationSettingsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetBySubjectId(int subjectId, string date)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(subjectId), subjectId.ToString());
            pars.Add(nameof(date), date.ToString());

            var dalResponse = await _db.ExecuteQuery("GetEvaluationSettingBySubjectId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(EvaluationSettings evaluationSettings)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveEvaluationSetting",
               _db.CreateListOfSqlParams(evaluationSettings, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(EvaluationSettings evaluationSettings)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateEvaluationSettings",
               _db.CreateListOfSqlParams(evaluationSettings, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
