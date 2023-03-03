using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IMentalityInquiriesService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int mentalityInquiriesId);
        Task<ServiceResponse> Delete(int mentalityInquiriesId);
        Task<ServiceResponse> Save(MentalityInquiriesViewModel mentalityInquiries);
        Task<ServiceResponse> Update(MentalityInquiriesViewModel mentalityInquiries);
    }
}
