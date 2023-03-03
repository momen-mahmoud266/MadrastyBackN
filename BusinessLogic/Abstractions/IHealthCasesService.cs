using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IHealthCasesService
    {
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> DeleteHealthCasesDetails(int id);
        Task<ServiceResponse> DeleteHealthCasesDetailsWithHealthId(int id);
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetHealthCasesDetails();
        Task<ServiceResponse> GetHealthCasesDetailsWithHealthId(int id);
        Task<ServiceResponse> GetHealthCasesDetailsWithId(int id);
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> Save(HealthCasesViewModel healthCases);
        Task<ServiceResponse> SaveHealthCasesDetails(HealthCasesViewModel healthCases);
        Task<ServiceResponse> Update(HealthCasesViewModel healthCases);
        Task<ServiceResponse> UpdateHealthCasesDetails(HealthCasesViewModel healthCases);
    }
}
