using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class AbsenceCaseDetailsViewModel
    {
        public int AbsenceCaseDetailsId { get; set; }
        public int AbsenceCaseId { get; set; }
        public string OtherSituations { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string EffortResults { get; set; } = string.Empty;
        public string EndYearState { get; set; }
    }
}
