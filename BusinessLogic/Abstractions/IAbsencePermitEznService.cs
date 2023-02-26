using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IAbsencePermitEznService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int absenceEznId);
        Task<ServiceResponse> Delete(int absenceEznId);
        Task<ServiceResponse> Save(AbsencePermitEznViewModel absenceEzn);
        Task<ServiceResponse> Update(AbsencePermitEznViewModel absenceEzn);
        Task<ServiceResponse> GetByEmployeeId(int employeeId);
        Task<ServiceResponse> GetByDepartmentId(int departmentId);
    }
}
