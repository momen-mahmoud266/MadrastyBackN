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
    public class NotificationService : INotificationService
    {
        private readonly IDatabaseContext _db;

        public NotificationService(IDatabaseContext db)
        {
            _db = db;
        }

        
        public async Task<ServiceResponse> Save(NotificationViewModel notification)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveNotification",
               _db.CreateListOfSqlParams(notification, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        

    }
}
