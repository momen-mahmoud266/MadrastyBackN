using BusinessLogic.Abstractions;
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
    public class PublicationServcie : IPublcationService
    {
        private readonly IDatabaseContext _db;

        public PublicationServcie(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeletePublication", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetPublications");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetPublicationById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(PublicationViewModel publication)
        {
            var dalResponse = await _db.ExecuteNonQuery("SavePublication",
               _db.CreateListOfSqlParams(publication, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(PublicationViewModel publication)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdatePublication",
               _db.CreateListOfSqlParams(publication, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
