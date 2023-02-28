using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class MonthValueViewModel
    {
        public int Ser { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public int FromEmpId { get; set; }

        public string Month { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
    }
}
