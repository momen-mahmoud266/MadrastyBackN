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
    public class AbsencePermitEznService : IAbsencePermitEznService
    {
        private readonly IDatabaseContext _db;

        public AbsencePermitEznService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteAbsencePermitEzn", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetAbsencePermitEzn");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetAbsencePermitEznById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetByEmployeeId(int employeeId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(employeeId), employeeId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetAbsencePermitEznByEmployeeId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByDepartmentId(int departmentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(departmentId), departmentId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetAbsencePermitEznByDepartmentId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(AbsencePermitEznViewModel abcenseEzn)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveAbsencePermitEzn",
               _db.CreateListOfSqlParams(abcenseEzn, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(AbsencePermitEznViewModel abcenseEzn)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateAbsencePermitEzn",
               _db.CreateListOfSqlParams(abcenseEzn, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
