using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class MessagesService
    {
        private readonly IDatabaseContext _db;

        public MessagesService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> Getinbox(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString()); ;
            var dalResponse = await _db.ExecuteQuery("Getinbox", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetById(int msgId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(msgId), msgId.ToString()); 
            var dalResponse = await _db.ExecuteQuery("GetById", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> Save(MessagesViewModel messages)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveLevels",
                          _db.CreateListOfSqlParams(messages, new List<string>() { "MsgId", "Date","Time", "ToEmpId", "Files", "Type", "Route", "ObjectId" }));

            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> SaveMessagesToEmpId(MessagesViewModel messages)
        {
          var dalResponse = await _db.ExecuteNonQuery("SaveMessagesToEmpId",
         _db.CreateListOfSqlParams(messages, new List<string>() { "FromEmpId", "Title", "Body", "Date", "Time", "Reply", "Files", "Type", "Route", "ObjectId" }));


            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> SaveMessagesFiles(MessagesViewModel messages)
        {

            var dalResponse = await _db.ExecuteNonQuery("SaveMessagesFiles",
                          _db.CreateListOfSqlParams(messages, new List<string>() { "FromEmpId", "Title", "ToEmpId", "Body", "Date", "Time", "Reply", "Route", "ObjectId" }));


            return new ServiceResponse(dalResponse);


        }
        public async Task<ServiceResponse> GetmessageWithToId(int toId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(toId), toId.ToString()); 
          
            var dalResponse = await _db.ExecuteQuery("GetmessageWithToId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetMessagesEmailsToEmpIdWithMsgId(int msgId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(msgId), msgId.ToString());
            var dalResponse = await _db.ExecuteQuery("GetMessagesEmailsToEmpIdWithMsgId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetmessageWithToIdEmails(int toId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(toId), toId.ToString());
            var dalResponse = await _db.ExecuteQuery("GetmessageWithToIdEmails", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetmessageWithToIdNoti(int toId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(toId), toId.ToString());
            var dalResponse = await _db.ExecuteQuery("GetmessageWithToIdNoti", pars);
            return new ServiceResponse(dalResponse);
        }
    }
}
