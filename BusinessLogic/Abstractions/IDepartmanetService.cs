using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IDepartmanetService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int departmentId);
        Task<ServiceResponse> Delete(int departmentId);
        Task<ServiceResponse> Save(DepartmentViewModel department);
        Task<ServiceResponse> Update(DepartmentViewModel department);
    }
}
