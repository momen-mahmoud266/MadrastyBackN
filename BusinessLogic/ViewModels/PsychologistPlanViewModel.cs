using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class PsychologistPlanViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Start { get; set; } = string.Empty;
        public string End { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;

    }
}
