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
    public class EvaluationItemService : IEvaluationItemService
    {

        private readonly IDatabaseContext _db;

        public EvaluationItemService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Save(EvaluationItems item)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveEvaluationItem",
               _db.CreateListOfSqlParams(item, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }
    }
}
