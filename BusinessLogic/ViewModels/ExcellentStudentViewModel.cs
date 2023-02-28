using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class ExcellentStudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LevelName { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string Nation { get; set; } = string.Empty;
        public int Mobile { get; set; }
        public string BirthDate { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public string Efforts { get; set; } = string.Empty;
    }
}
