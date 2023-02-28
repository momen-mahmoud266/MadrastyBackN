using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class DelayViewModel
    {
        public int Id { get; set; }
        public string Date { get; set; } = string.Empty;
        public string EmployeeName { get; set; } = string.Empty;
        public int EmployeeId { get; set; }
        public string AttendanceTime { get; set; } = string.Empty;
        public int State { get; set; }
      
    }
}
