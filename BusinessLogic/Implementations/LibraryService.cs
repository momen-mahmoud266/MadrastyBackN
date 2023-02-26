using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class LibraryService : ILibraryService
    {
        private readonly IDatabaseContext _db;

        public LibraryService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int libraryId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(libraryId), libraryId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteLibrary", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetLibraries");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int libraryId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(libraryId), libraryId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetLibraryById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(LibraryViewModel library)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveLibrary",
              _db.CreateListOfSqlParams(library, new List<string>() { "LibraryId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(LibraryViewModel library)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateLibrary",
                _db.CreateListOfSqlParams(library, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
