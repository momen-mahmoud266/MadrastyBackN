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
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(department.DepartmentName), Value = department.DepartmentName });
            param.Add(new SqlParameter { ParameterName = nameof(department.DepartmentDesc), Value = department.DepartmentDesc });
            param.Add(new SqlParameter { ParameterName = nameof(department.DepartmentSupervisorId), Value = department.DepartmentSupervisorId });
            param.Add(new SqlParameter { ParameterName = nameof(department.DepartmentSupervisorName), Value = department.DepartmentSupervisorName });
            param.Add(new SqlParameter { ParameterName = nameof(department.ParentId), Value = department.ParentId });

            var result = await _db.ExecuteNonQuery("SaveDepartment", param);
            return new ServiceResponse(result);
        }

        public async Task<ServiceResponse> Update(DepartmentViewModel department)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(department.DepartmentId), Value = department.DepartmentId });
            param.Add(new SqlParameter { ParameterName = nameof(department.DepartmentName), Value = department.DepartmentName });
            param.Add(new SqlParameter { ParameterName = nameof(department.DepartmentDesc), Value = department.DepartmentDesc });
            param.Add(new SqlParameter { ParameterName = nameof(department.DepartmentSupervisorId), Value = department.DepartmentSupervisorId });
            param.Add(new SqlParameter { ParameterName = nameof(department.DepartmentSupervisorName), Value = department.DepartmentSupervisorName });
            param.Add(new SqlParameter { ParameterName = nameof(department.ParentId), Value = department.ParentId });

            var result = await _db.ExecuteNonQuery("UpdateDepartment", param);
            return new ServiceResponse(result);
        }
    }
}
