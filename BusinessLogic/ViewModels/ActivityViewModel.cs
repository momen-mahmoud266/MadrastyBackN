using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class ActivityViewModel
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string ActivityDepartment { get; set; }
        public string ActivitySchoolYear { get; set; }
        public int ActivitySchoolYearId { get; set; }
        public int ActivityLevel { get; set; }
        public string ActivityDate { get; set; }
        public int ActivitySchoolTerm { get; set; }
        public string ActivityNotes { get; set; }
        public int ParentId { get; set; }
    }
}
