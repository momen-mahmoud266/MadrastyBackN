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
        Task<ServiceResponse> DeleteHealthCases(int id);
        Task<ServiceResponse> DeleteHealthCasesDetails(int id);
        Task<ServiceResponse> DeleteHealthCasesDetailsWithHealthId(int id);
        Task<ServiceResponse> GetHealthCases();
        Task<ServiceResponse> GetHealthCasesDetails();
        Task<ServiceResponse> GetHealthCasesDetailsWithHealthId(int id);
        Task<ServiceResponse> GetHealthCasesDetailsWithId(int id);
        Task<ServiceResponse> GetHealthCasesWithId(int id);
        Task<ServiceResponse> SaveHealthCases(HealthCasesViewModel healthCases);
        Task<ServiceResponse> SaveHealthCasesDetails(HealthCasesViewModel healthCases);
        Task<ServiceResponse> UpdateHealthCases(HealthCasesViewModel healthCases);
        Task<ServiceResponse> UpdateHealthCasesDetails(HealthCasesViewModel healthCases);
    }
}
