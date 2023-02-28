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
    public class InstructionsService : IInstructionsService
    {

        private readonly IDatabaseContext _db;

        public InstructionsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> DeleteInstructions(int instructionsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(instructionsId), instructionsId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteInstructions", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetInstructions()
        {
            var dalResponse = await _db.ExecuteQuery("GetInstructions");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetInstructionsById(int instructionsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(instructionsId), instructionsId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetInstructionsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> SaveInstructions(InstructionsViewModel instructions)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveInstructions",
               _db.CreateListOfSqlParams(instructions, new List<string>() { "Ser" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> UpdateInstructions(InstructionsViewModel instructions)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateInstructions",
               _db.CreateListOfSqlParams(instructions, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetInstructionsStat()
        {
            var dalResponse = await _db.ExecuteQuery("GetInstructionsStat");
            return new ServiceResponse(dalResponse);
        }
    }
}
