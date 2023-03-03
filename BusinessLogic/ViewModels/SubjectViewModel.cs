using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SubjectViewModel
    {
        public int SubjectId { get; set; }
        public int EmpId { get; set; }

        public string SubjectName { get; set; } = string.Empty;
        public string SubjectDesc { get; set; } = string.Empty;

        public int EmpSubjectId { get; set; }
        public string EmpSubjectName { get; set; } = string.Empty;

        public int DepId { get; set; }
        public int ParentId { get; set; }
        public string DepName { get; set; } = string.Empty;
    }
}
