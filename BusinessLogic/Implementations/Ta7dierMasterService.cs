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
    public class Ta7dierMasterService : ITa7dierMasterService
    {
        private readonly IDatabaseContext _db;

        public Ta7dierMasterService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int ta7dierId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ta7dierId), ta7dierId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteTa7dier", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetTa7diers");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int ta7dierId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ta7dierId), ta7dierId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetTa7dierById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(Ta7dierMasterViewModel ta7dier)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveTa7dier",
               _db.CreateListOfSqlParams(ta7dier, new List<string>() { "Ta7dierId", "DepId", "Route", "ToEmpId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(Ta7dierMasterViewModel ta7dier)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateTa7dier",
               _db.CreateListOfSqlParams(ta7dier, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
        ///////////////////
        public async Task<ServiceResponse> GetBySubjectId(int subjectId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(subjectId), subjectId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetBySubjectId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> UpdateState(int ta7dierId, int state)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ta7dierId), ta7dierId.ToString());
            pars.Add(nameof(state), state.ToString());
            var dalResponse = await _db.ExecuteQuery("UpdateState", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByDepId(int depId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(depId), depId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetByDepId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetForDashBoard(int empId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(empId), empId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetForDashBoard", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
