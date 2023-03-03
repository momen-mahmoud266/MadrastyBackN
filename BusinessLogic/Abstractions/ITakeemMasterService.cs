using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ITakeemMasterService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int takeemMasterId);
        Task<ServiceResponse> Delete(int takeemMasterId);
        Task<ServiceResponse> Save(TakeemMasterViewModel takeemMaster);
        Task<ServiceResponse> Update(TakeemMasterViewModel takeemMaster);

        Task<ServiceResponse> GetDetails();
        Task<ServiceResponse> GetDetailsById(int takeemMasterDetailsId);
        Task<ServiceResponse> DeleteDetails(int takeemMasterDetailsId);
        Task<ServiceResponse> SaveDetails(TakeemMasterDetailsViewModel takeemMasterDetails);
        Task<ServiceResponse> UpdateDetails(TakeemMasterDetailsViewModel takeemMasterDetails);
        Task<ServiceResponse> GetDetailsByTakeemId(int takeemMasterId);
        Task<ServiceResponse> GetEvaluationWithEvaluationSubject(int EvaluationSubjectId, string EvaluationDate);
    }
}
