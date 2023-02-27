using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class AbsenceStatisticsViewModel
    {
        public int Id { get; set; }
        public int LevelId { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public string BranchName { get; set; } = string.Empty;
        public int BranchId { get; set; }
        public int StudentsTotalNumber { get; set; }
        public int StudentsAttendanceNumber { get; set; }
        public int StudentsAbsenceNumber { get; set; }
        public int StudentAttendanceScore { get; set; }
        public int TearchersTotalNumber { get; set; }
        public int TeachersAttendanceNumber { get; set; }
        public int TeacherAbsenceNumber { get; set; }
        public int TeacherAttendenceScore { get; set; }
        
    }
}
