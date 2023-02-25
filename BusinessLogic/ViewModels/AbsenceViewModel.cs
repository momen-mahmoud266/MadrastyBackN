using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class AbsenceViewModel
    {
        public int AbsenceId { get; set; }
        public string AbsenceLevel { get; set; }
        public string AbsenceClass { get; set; }
        public string AbsenceDate { get; set; }
        public int AbsenceStudentId { get; set; }
        public string AbsenceStudentName { get; set; }
    }
}
