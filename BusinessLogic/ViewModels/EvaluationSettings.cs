using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class EvaluationSettings
    {
        public int Id { get; set; }
        public int ObjectId { get; set; }
        public string ObjectName { get; set; } = string.Empty;
        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public string Appreciation { get; set; } = string.Empty;
        public int Score { get; set; }

    }
}
