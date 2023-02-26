using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class BehaviourStatusDetailsViewModel
    {
        public int Id { get; set; }
        public int BehaviourStatusId { get; set; }
        public int StudentId { get; set; }
        public string AnotherSituations { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Efforts { get; set; } = string.Empty;
        public string EndYearSituation { get; set; } = string.Empty;
    }
}
