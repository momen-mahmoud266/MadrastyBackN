using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class OtherStudentsSlides
    {
        public int Id { get; set; }
        public int LevelId { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int ClasssId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public int DefinitionId { get; set; }
        public string DefinitionName { get; set; } = string.Empty;
        public string SlideType { get; set; } = string.Empty;
        public string DateOfFileOpening { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string Results { get; set; } = string.Empty; 
    }
}
