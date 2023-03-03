using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISchoolYearDataService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int schoolYearDataId);
        Task<ServiceResponse> Delete(int schoolYearDataId);
        Task<ServiceResponse> Save(SchoolYearDataViewModel schoolYearData);
        Task<ServiceResponse> Update(SchoolYearDataViewModel schoolYearData);
        Task<ServiceResponse> GetSchoolYearDataForDropdown();

        Task<ServiceResponse> GetDetails();
        Task<ServiceResponse> GetDetailsById(int schoolYearDataDetailId);
        Task<ServiceResponse> DeleteDetails(int schoolYearDataId);
        Task<ServiceResponse> SaveDetails(SchoolYearDataDetailsViewModel schoolYearDataDetails);
        Task<ServiceResponse> UpdateDetails(SchoolYearDataDetailsViewModel schoolYearDataDetails);
        Task<ServiceResponse> GetDetailsByYearId(int schoolYearDataId);
        Task<ServiceResponse> DeleteDetailsByYear(int schoolYearDataId);
    }
}
