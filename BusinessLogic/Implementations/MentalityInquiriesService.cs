using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class MentalityInquiriesService
    {
        private readonly IDatabaseContext _db;

        public MentalityInquiriesService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> DeleteMentalityInquiries(int mentalityInquiriesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(mentalityInquiriesId), mentalityInquiriesId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteMentalityInquiries", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetMentalityInquiries()
        {
            var dalResponse = await _db.ExecuteQuery("GetMentalityInquiries");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetMentalityInquiriesById(int mentalityInquiriesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(mentalityInquiriesId), mentalityInquiriesId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetMentalityInquiriesById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> SaveMentalityInquiries(MentalityInquiriesViewModel mentalityInquiries)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveMentalityInquiries",
               _db.CreateListOfSqlParams(mentalityInquiries, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateMentalityInquiries(MentalityInquiriesViewModel mentalityInquiries)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateMentalityInquiries",
               _db.CreateListOfSqlParams(mentalityInquiries, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetMentalityInquiriesStat()
        {
            var dalResponse = await _db.ExecuteQuery("GetMentalityInquiriesStat");
            return new ServiceResponse(dalResponse);
        }
    }
}
