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
        Task<ServiceResponse> GetMentalityInquiries();
        Task<ServiceResponse> GetMentalityInquiriesById(int mentalityInquiriesId);
        Task<ServiceResponse> DeleteMentalityInquiries(int mentalityInquiriesId);
        Task<ServiceResponse> SaveMentalityInquiries(MentalityInquiriesViewModel mentalityInquiries);
        Task<ServiceResponse> UpdateMentalityInquiries(MentalityInquiriesViewModel mentalityInquiries);
    }
}
