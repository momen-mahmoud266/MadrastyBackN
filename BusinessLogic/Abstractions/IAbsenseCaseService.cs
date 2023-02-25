using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IAbsenseCaseService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int absenceCaseId);
        Task<ServiceResponse> Delete(int absenceCaseId);
        Task<ServiceResponse> Save(AbsenceCaseViewModel absenceCase);
        Task<ServiceResponse> Update(AbsenceCaseViewModel absenceCase);
    }
}
