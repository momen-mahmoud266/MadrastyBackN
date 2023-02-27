using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class EvaluationItems
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Appreciation { get; set; } = string.Empty;
        public string Score { get; set; } = string.Empty;

    }
}
