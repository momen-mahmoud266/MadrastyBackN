using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class LevelsViewModel
    {
        public int LevelId { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int LevelClassNo { get; set; }
        public string LevelDesc { get; set; } = string.Empty;

        public string NumStudents { get; set; } = string.Empty;

        public string NumClasses { get; set; } = string.Empty;

        public string TotalStudents { get; set; } = string.Empty;

        public string TotalClasses { get; set; } = string.Empty;
    }
}
