using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class MentalityInquiriesViewModel
    {
        public int Id { get; set; }
     
        public string ProblemType { get; set; } = string.Empty;
        
        public string Answer { get; set; } = string.Empty;
        public string Ntoes { get; set; } = string.Empty;
    }
}
