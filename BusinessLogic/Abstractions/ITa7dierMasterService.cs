using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ITa7dierMasterService
    {
        Task<ServiceResponse> Save(Ta7dierMasterViewModel ta7dier);
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int ta7dierId);
        Task<ServiceResponse> Update(Ta7dierMasterViewModel ta7dier);
        Task<ServiceResponse> Delete(int ta7dierId);


        Task<ServiceResponse> GetBySubjectId(int subjectId);
        Task<ServiceResponse> UpdateState(int ta7dierId, int state);    
        Task<ServiceResponse> GetByDepId(int depId);
        Task<ServiceResponse> GetForDashBoard(int empId);


    }
}
