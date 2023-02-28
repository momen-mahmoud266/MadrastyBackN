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
        Task<ServiceResponse> GetIndividualCases();
        Task<ServiceResponse> GetByIndividualCasesId(int individualCasesId);
        Task<ServiceResponse> DeleteIndividualCases(int individualCasesId);
        Task<ServiceResponse> SaveIndividualCases(IndividualCasesViewModel individualCases);
        Task<ServiceResponse> UpdateIndividualCases(IndividualCasesViewModel individualCases);
    }
}
