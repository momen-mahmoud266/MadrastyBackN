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
    public class WorkPlanService : IWorkPlanService
    {
        private readonly IDatabaseContext _db;

        public WorkPlanService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int WorkPlanId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(WorkPlanId), WorkPlanId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteWorkPlan", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetWorkPlans");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int WorkPlanId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(WorkPlanId), WorkPlanId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetWorkPlanById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(WorkPlanViewModel WorkPlan)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveWorkPlan",
               _db.CreateListOfSqlParams(WorkPlan, new List<string>() { "Ser" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(WorkPlanViewModel WorkPlan)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateWorkPlan",
               _db.CreateListOfSqlParams(WorkPlan, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
