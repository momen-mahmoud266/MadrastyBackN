using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface INewWorkService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> Save(NewWorkViewModel newWork);
        Task<ServiceResponse> Update(NewWorkViewModel newWork);
    }
}
