using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class AbsenceCaseViewModel
    {
        public int AbsenceCasesId { get; set; }
        public int LevelId { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty; 
        public int NationalityId { get; set; }
        public string NationalityName { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public string BirthDate { get; set; } = string.Empty;
        public string WorkStartDate { get; set; } = string.Empty;
        public string BehavioralNotes { get; set; } = string.Empty;
        public string SelfReasons { get; set; } = string.Empty;

    }
}
