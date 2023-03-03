using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class TakeemMasterViewModel
    {
        public int TakeemId { get; set; }
        public int EvaluationId { get; set; }
        public int EvaluationObject { get; set; }
        public string EvaluationObjectName { get; set; } = string.Empty;
        public string EvaluationSubject { get; set; } = string.Empty;
        public int EvaluationSubjectId { get; set; }
        public int TheObjectId { get; set; }
        public string EvaluationDate { get; set; } = string.Empty;
    }
    public class TakeemMasterDetailsViewModel
    {
        public int TakeemDetailId { get; set; }
        public int TakeemId { get; set; }
        public int EvaluationItemId { get; set; }
        public string EvaluationItemName { get; set; } = string.Empty;
        public string EvaluationAppreciation { get; set; } = string.Empty;
        public int EvaluationScore { get; set; }
        public int EvaluationResult { get; set; }
        public int EvaluationSubjectId { get; set; }
        public string EvaluationDate { get; set; } = string.Empty;
    }
}
