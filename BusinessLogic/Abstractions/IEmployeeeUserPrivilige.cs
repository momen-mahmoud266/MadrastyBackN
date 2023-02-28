using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IEmployeeeUserPrivilige
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> DeleteByEmployeeId(int employeeId);
        Task<ServiceResponse> Save(EmployeeUserPriviligeViewModel employee);
        Task<ServiceResponse> Update(EmployeeUserPriviligeViewModel employee);
        Task<ServiceResponse> GetMenusRoutesFromEmployeePrivilige(int employeeId);
        Task<ServiceResponse> GetMenusRouteFromEmployeePriviligeByRoute(int employeeId, string route);
    }
}
