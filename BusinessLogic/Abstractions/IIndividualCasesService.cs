using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IIndividualCasesService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int individualCasesId);
        Task<ServiceResponse> Delete(int individualCasesId);
        Task<ServiceResponse> Save(IndividualCasesViewModel individualCases);
        Task<ServiceResponse> Update(IndividualCasesViewModel individualCases);
    }
}
