using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IInstructionsService
    {
        Task<ServiceResponse> GetInstructions();
        Task<ServiceResponse> GetInstructionsById(int instructionsId);
        Task<ServiceResponse> DeleteInstructions(int instructionsId);
        Task<ServiceResponse> SaveInstructions(InstructionsViewModel instructions);
        Task<ServiceResponse> UpdateInstructions(InstructionsViewModel instructions);
    }
}
