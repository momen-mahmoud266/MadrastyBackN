using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IAdvertimentService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int advertismentId);
        Task<ServiceResponse> Delete(int advertismentId);
        Task<ServiceResponse> Save(AdvertismentViewModel advertisment);
        Task<ServiceResponse> Update(AdvertismentViewModel advertisment);
        Task<ServiceResponse> GetAdvertismentsForLogin();
        Task<ServiceResponse> GetAdvertismentForDashboard(int isPublic, int departmentId);

    }
}
