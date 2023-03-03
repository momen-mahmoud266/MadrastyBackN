using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IStudentService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int studentId);
        Task<ServiceResponse> Delete(int studentId);
        Task<ServiceResponse> Save(StudentViewModel student);
        Task<ServiceResponse> Update(StudentViewModel student);

        Task<ServiceResponse> GetByClassId(int studentId);
        Task<ServiceResponse> GetByGradeId(int studentId);
        Task<ServiceResponse> UpdateStudentBranch(int studentId, int studentBranch);
        Task<ServiceResponse> UpdateStudentClass(int studentId, int studentClassId, string studentClassName);
        Task<ServiceResponse> GetStartDateFromSchoolYearConfig();
        Task<ServiceResponse> GetBranchStatistics();
    }
}
