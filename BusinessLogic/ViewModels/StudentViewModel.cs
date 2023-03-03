using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class StudentViewModel
    {
        public string StartYearDate { get; set; } = String.Empty;
        public int StudentId { get; set; }
        public int StudentFileSer { get; set; }
        public string StudentCivilianId { get; set; } = String.Empty;
        public string StudentSex { get; set; } = String.Empty;
        public int StudentSexId { get; set; }
        public string StudentName { get; set; } = String.Empty;
        public string StudentNationality { get; set; } = String.Empty;
        public int StudentNationalityId { get; set; }
        public string StudentDob { get; set; } = String.Empty;
        public int StudentAgeYear { get; set; }

        public int StudentAgeMonth { get; set; }
        public int StudentAgeDay { get; set; }
        public int StudentAcceptanceReasonId { get; set; }
        public string StudentAcceptanceReason { get; set; } = String.Empty;
        public string StudentReligion { get; set; } = String.Empty;
        public int StudentReligionId { get; set; }
        public string StudentDistrict { get; set; } = String.Empty;
        public int StudentDistrictId { get; set; }
        public string StudentSchool { get; set; } = String.Empty;
        public string StudentStage { get; set; } = String.Empty;

        public int StudentStageId { get; set; }
        public string StudentState { get; set; } = String.Empty;
        public int StudentStateId { get; set; }
        public string StudentStudyState { get; set; } = String.Empty;
        public int StudentStudyStateId { get; set; }
        public string StudentGrade { get; set; } = String.Empty;

        public int StudentGradeId { get; set; }
        public string StudentDiv { get; set; } = String.Empty;
        public int StudentDivId { get; set; }
        public int StudentFailureYears { get; set; }

        public int StudentClassId { get; set; }
        public string StudentClassName { get; set; } = String.Empty;

        public string StudentBranch { get; set; } = String.Empty;
        public int id { get; set; }

        public string Level11 { get; set; } = String.Empty;

        public string Level12 { get; set; } = String.Empty;

        public string StudentBranchStat { get; set; } = String.Empty;

        public string TotalStudents { get; set; } = String.Empty;

        public string BirthCertNo { get; set; } = String.Empty;
        public int BirthCertSourceId { get; set; }
        public string BirthCertSource { get; set; } = String.Empty;
        public string BirthCertDate { get; set; } = String.Empty;
        public int BirthLocationId { get; set; }
        public string BirthLocation { get; set; } = String.Empty;
        public int GovId { get; set; }
        public string GovName { get; set; } = String.Empty;
        public int CityId { get; set; }
        public string CityName { get; set; } = String.Empty;
        public int Elkt3a { get; set; }
        public string Street { get; set; } = String.Empty;
        public int Elgada { get; set; }
        public int Building { get; set; }
        public int BuildLevel { get; set; }
        public int ApartNo { get; set; }
        public string Phone { get; set; } = String.Empty;
        public string NameInEnglish { get; set; } = String.Empty;
        public int GuardianRelationId { get; set; }
        public string GuardianRelation { get; set; } = String.Empty;
        public string GuardianCivilianId { get; set; } = String.Empty;
        public string GuardMobile { get; set; } = String.Empty;
        public string GuardianName { get; set; } = String.Empty;
        public string WorkPhone { get; set; } = String.Empty;
        public string WorkName { get; set; } = String.Empty;
        public string JobName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public int GuardGovId { get; set; }
        public string GuardgovName { get; set; } = String.Empty;
        public int GuardCityId { get; set; }
        public string GuardCityName { get; set; } = String.Empty;
        public int GuardKt3a { get; set; }
        public string GuardStreet { get; set; } = String.Empty;
        public int GuardBuild { get; set; }
        public int GuardBuildLevel { get; set; }
        public string GuardPhone { get; set; } = String.Empty;
        public string MotherName { get; set; } = String.Empty;
        public string MotherCivilianId { get; set; } = String.Empty;
        public int MotherNatId { get; set; }
        public string MotherNationality { get; set; } = String.Empty;
        public string MotherPhone { get; set; } = String.Empty;
        public string MotherMobile { get; set; } = String.Empty;
    }
}
