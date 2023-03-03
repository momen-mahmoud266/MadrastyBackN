using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class WorkPlanViewModel
    {
        public string Ser { get; set; } = string.Empty;
        public string WorkPlanName { get; set; } = string.Empty;
        public string WorkPlanId { get; set; } = string.Empty;
        public string Program { get; set; } = string.Empty;
        public string FulfilmentDate { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
        public string NonFulfilmentReason { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

    }
}
