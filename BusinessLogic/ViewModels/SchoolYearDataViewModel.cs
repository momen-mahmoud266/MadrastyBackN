using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SchoolYearDataViewModel
    {
        public int YearDataId { get; set; }

        public string YearDateFrom { get; set; } = string.Empty;

        public string YearDateTo { get; set; } = string.Empty;
        public string YearData { get; set; } = string.Empty;
    }
    public class SchoolYearDataDetailsViewModel
    {
        public int YearDetailsId { get; set; }
        public int YearDataId { get; set; }
        public string TermDateFrom { get; set; } = string.Empty;
        public string TermDateTo { get; set; } = string.Empty;
    }
}
