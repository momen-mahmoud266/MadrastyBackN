using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class DefinitionViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SCode { get; set; } = string.Empty;
        public string SCodeArabic { get; set; } = string.Empty;
    }
}
