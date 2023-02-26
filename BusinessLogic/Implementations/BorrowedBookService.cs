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
    public class BorrowedBookService : IBorrowedBookService
    {
        private readonly IDatabaseContext _db;

        public BorrowedBookService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteBorrowedBook", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetBorrowedBooks");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetBorrowedBookById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(BorrowedBookViewModel borrowedBook)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveBorrowedBook",
                _db.CreateListOfSqlParams(borrowedBook,new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(BorrowedBookViewModel borrowedBook)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateBorrowedBook",
                _db.CreateListOfSqlParams(borrowedBook, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
