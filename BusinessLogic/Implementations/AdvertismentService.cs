using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BusinessLogic.Implementations
{
    public class AdvertismentService : IAdvertimentService
    {
        private readonly IDatabaseContext _db;

        public AdvertismentService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int advertismentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(advertismentId), advertismentId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteAdvertisment", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetAdvertisments");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetAdvertismentsForLogin()
        {
            var dalResponse = await _db.ExecuteQuery("GetAdvertismentsForLogin");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int advertismentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(advertismentId), advertismentId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetAdvertismentById", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetAdvertismentForDashboard(int isPublic, int departmentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(isPublic), isPublic.ToString());
            pars.Add(nameof(departmentId), departmentId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetAdvertismentForDashboard", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(AdvertismentViewModel advertisment)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveAdvertisment",
             _db.CreateListOfSqlParams(advertisment, new List<string>() { "AdvertimentId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(AdvertismentViewModel advertisment)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateAdvertisment",
               _db.CreateListOfSqlParams(advertisment, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
