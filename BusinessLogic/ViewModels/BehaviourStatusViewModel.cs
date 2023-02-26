using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class BehaviourStatusViewModel
    {
        public int Id { get; set; }
        public string StatusType { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public string Reasons { get; set; } = string.Empty;
        public int LevelId { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
    }
}
