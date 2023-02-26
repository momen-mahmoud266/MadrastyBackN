using  BusinessLogic.Abstractions;
using  BusinessLogic.Contexts;
using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using  System.Linq;
using System.Reflection;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class DepartmentService : IDepartmanetService
    {
        private readonly IDatabaseContext _db;

        public DepartmentService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int departmentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(departmentId), departmentId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteDepartment", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetDepartments");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int departmentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(departmentId), departmentId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetDepartmentById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(DepartmentViewModel department)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveDepartment",
               _db.CreateListOfSqlParams(department, new List<string>() { "DepartmentId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(DepartmentViewModel department)
        {
             var dalResponse = await _db.ExecuteNonQuery("UpdateDepartment",
                _db.CreateListOfSqlParams(department, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
