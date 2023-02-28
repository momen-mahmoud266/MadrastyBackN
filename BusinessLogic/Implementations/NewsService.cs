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
    public class NewsService : INewsService
    {

        private readonly IDatabaseContext _db;

        public NewsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetNews");
            return new ServiceResponse(dalResponse);
        }

    }
}
