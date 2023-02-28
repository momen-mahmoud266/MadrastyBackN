using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class IndividualCasesViewModel
    {
        public int Id { get; set; }
        public int LevelId { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public int DefId { get; set; }
        public string SCode { get; set; } = string.Empty;
        public string CaseType { get; set; } = string.Empty;
        public string DateOfFileOpening { get; set; } = string.Empty;
        public string TransferProcedures { get; set; } = string.Empty;
        public string Results { get; set; } = string.Empty;
    }
}
