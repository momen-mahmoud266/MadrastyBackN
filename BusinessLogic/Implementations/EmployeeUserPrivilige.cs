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
    public class EmployeeUserPrivilige : IEmployeeeUserPrivilige
    {
        private readonly IDatabaseContext _db;

        public EmployeeUserPrivilige(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteEmployeePriviligeByEmployeeId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> DeleteByEmployeeId(int employeeId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(employeeId), employeeId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteEmployeePriviligeByEmployeeId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetEmployeesPrivilige");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetEmployeeById", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByEmployeeId(int employeeId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(employeeId), employeeId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetEmployeePriviligeByEmployeeId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetMenusRoutesFromEmployeePrivilige(int employeeId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(employeeId), employeeId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetMenusRoutesFromEmployeePrivilige", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetMenusRouteFromEmployeePriviligeByRoute(int employeeId,string route)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(employeeId), employeeId.ToString());
            pars.Add(nameof(route), route);

            var dalResponse = await _db.ExecuteQuery("GetMenusRouteFromEmployeePriviligeByRoute", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(EmployeeUserPriviligeViewModel employee)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveEmployeePrivilige",
                _db.CreateListOfSqlParams(employee, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(EmployeeUserPriviligeViewModel employee)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveAndUpdateEmployeePrivilige",
                _db.CreateListOfSqlParams(employee, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

      
    }
}
