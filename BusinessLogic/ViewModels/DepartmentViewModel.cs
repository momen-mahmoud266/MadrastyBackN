using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; }
        public int ParentId { get; set; }
        public string ParentName { get; set; } = string.Empty;
        public string DepartmentName { get; set; } = string.Empty;
        public string DepartmentDesc { get; set; } = string.Empty;
        public int DepartmentSupervisorId { get; set; }
        public string DepartmentSupervisorName { get; set; } = string.Empty;
    }
}
