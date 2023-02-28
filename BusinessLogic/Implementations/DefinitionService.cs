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
    public class DefinitionService : IDefinitionService
    {
        private readonly IDatabaseContext _db;

        public DefinitionService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteDefinition", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetDefinitions");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetSCodeArabic()
        {
            var dalResponse = await _db.ExecuteQuery("GetSCodeArabicFromDefinitions");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetDefinitionById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(DefinitionViewModel definition)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveDefinition",
               _db.CreateListOfSqlParams(definition, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(DefinitionViewModel definition)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateDefinition",
               _db.CreateListOfSqlParams(definition, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
