using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class AbsencePermitEznViewModel
    {
        public int Id { get; set; }
        public int AbsenceEznId { get; set; }
        public int PermitId { get; set; }
        public int EmployeeId { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Reasons { get; set; } = string.Empty;
        public string FromTime { get; set; } = string.Empty;    
        public string ToTime { get; set; } = string.Empty;
        public int EznState { get; set; } 
    }
}
