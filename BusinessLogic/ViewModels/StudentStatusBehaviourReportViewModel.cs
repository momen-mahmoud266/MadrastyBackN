using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class StudentStatusBehaviourReportViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string LevId { get; set; } = string.Empty;
        public string ClassId { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public string Report { get; set; } = string.Empty;
        public string HeadDepOpinion { get; set; } = string.Empty;
        public string SupervisorOpinion { get; set; } = string.Empty;
        public string SocialWorkerOpinion { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
    }
}
