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
    public class EmployeeService : IEmployeeService
    {
        private readonly IDatabaseContext _db;

        public EmployeeService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteEmployee", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetEmployees");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetEmployeeById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetByJobId(int jobId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(jobId), jobId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetEmployeeByJobId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetBySubjectId(int subjectId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(subjectId), subjectId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetEmployeeBySubjectId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetBySubjectIdAndValidation(int subjectId, string start)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(subjectId), subjectId.ToString());
            pars.Add(nameof(start), start);

            var dalResponse = await _db.ExecuteQuery("GetEmployeeBySubjectIdAndValidation", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(EmployeeViewModel employee)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveEmployee",
                _db.CreateListOfSqlParams(employee, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(EmployeeViewModel employee)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateEmployee",
                _db.CreateListOfSqlParams(employee, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
