using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class InstructionsViewModel
    {
        public int Ser { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int levelId { get; set; }
        public string ClassName { get; set; } = string.Empty;
      
        public int ClassId { get; set; }
        public string Topic { get; set; } = string.Empty;
       
        public int GroupNumber { get; set; }
      
        public int SessionsNumber { get; set; }
        public string Notes { get; set; } = string.Empty;
        public int TypeId { get; set; }
        public string TypeName { get; set; } = string.Empty;
    }
}
