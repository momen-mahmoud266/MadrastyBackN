using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CivilNo { get; set; } = string.Empty;
        public string Sex { get; set; } = string.Empty;
        public int SexId { get; set; }
        public int NationalityId { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public int MaritalStatusId { get; set; }    
        public string MaritalStatus { get; set; } = string.Empty;
        public int FileSerialNumber { get; set; }
        public string DateOfBirth { get; set; } = string.Empty;
        public int AgeInYear { get; set; }
        public int AgeInMonth { get; set; }
        public int AgeInDay { get; set; }
        public int PositionTypeId { get; set; }
        public string PositionType { get; set; } = string.Empty;
        public int PositionId { get; set; }
        public string Position { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public int DepartmentParent { get; set; }
        public int SubjectId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public int DivisionId { get; set; }
        public string Division { get; set; } = string.Empty;
        public int ConrtactId { get; set; }
        public string Contract { get; set; } = string.Empty;
        public string EmploymentDate { get; set; } = string.Empty;
        public int EducationQualificationId { get; set; }   
        public string EducationQualification { get; set; } = string.Empty;
        public string EducationQualificationDate { get; set; } = string.Empty;
        public string EducationQualificationCountry { get; set; } = string.Empty;
        public int EducationQualificationCountryId { get; set; }
        public int ExpirationOutCountry { get; set; }
        public int ExpirationInCountrySameGrade { get; set; }
        public int ExpirationInCountryAnotherGrade { get; set; }
        public int ExpirationInCountrySameSchool { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MobileNo { get; set; } = string.Empty;
        public string AnotherMobileNo { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int PriviligeInClass { get; set; }
        public int DepartmentWork { get; set; }
        public string ConnectionId { get; set; } = string.Empty;
        public int ReligionId { get; set; }
        public string ReligionName { get; set; } = string.Empty;
    }
}
