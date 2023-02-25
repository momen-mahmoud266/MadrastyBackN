using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IAbsenceService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int absenceId);
        Task<ServiceResponse> Delete(int absenceId);
        Task<ServiceResponse> Save(AbsenceViewModel absenceStudent);
        Task<ServiceResponse> Update(AbsenceViewModel absenceStudent);
    }
}
