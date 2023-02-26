using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IBorrowedBookService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int Id);
        Task<ServiceResponse> Delete(int Id);
        Task<ServiceResponse> Save(BorrowedBookViewModel borrowedBook);
        Task<ServiceResponse> Update(BorrowedBookViewModel borrowedBook);
    }
}
