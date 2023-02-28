using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class EmployeeUserPriviligeViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string PriviligeName { get; set; } = string.Empty;
        public string PageName { get; set; } = string.Empty;
        public int PriviligeInClass { get; set; }
        public int DepartmentWork { get; set; }
        public int JobId { get; set; }
        public int ReadPrivilige { get; set; }
        public int WritePrivilige { get; set; }
        public int ReadAndWritePrivilige { get; set; }
    }
}
