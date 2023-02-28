using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class HealthCasesViewModel
    {
        public int HealthId { get; set; }
        public int LevelId { get; set; }
        public string levelName { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public int NationalityId { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public string BirthDate { get; set; } = string.Empty;
        public string WorkStartDate { get; set; } = string.Empty;
        public string DisStatus { get; set; } = string.Empty;
        public string HealthRecomm { get; set; } = string.Empty;
        public string YearEndState { get; set; } = string.Empty;

        public int HealthDetId { get; set; }
      
        public string OtherSituations { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string EffortResults { get; set; } = string.Empty;
        public string EndYearState { get; set; } = string.Empty;
    }
}
