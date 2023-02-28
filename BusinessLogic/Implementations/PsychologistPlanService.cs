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
    public class PsychologistPlanService : IPsychologistPlanService
    {
        private readonly IDatabaseContext _db;

        public PsychologistPlanService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeletePsychologistPlan", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetPsychologistPlans");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetPsychologistPlanById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(PsychologistPlanViewModel psychologistPlan)
        {
            var dalResponse = await _db.ExecuteNonQuery("SavePsychologistPlan",
               _db.CreateListOfSqlParams(psychologistPlan, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(PsychologistPlanViewModel psychologistPlan)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdatePsychologistPlan",
               _db.CreateListOfSqlParams(psychologistPlan, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
