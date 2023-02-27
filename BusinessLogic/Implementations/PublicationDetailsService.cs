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
    public class PublicationDetailsService : IPublicationDetailsService
    {
        private readonly IDatabaseContext _db;

        public PublicationDetailsService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeletePublictaionDetails", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetPublicationDetails");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetPublicationDetailsById", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByPublicationId(int publicationId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(publicationId), publicationId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetPublicationDetailsByPublicationId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(PublicationDetailsViewModel publicationDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("SavePublicationDetails",
               _db.CreateListOfSqlParams(publicationDetails, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(PublicationDetailsViewModel publicationDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdatePublicationDetails",
               _db.CreateListOfSqlParams(publicationDetails, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
