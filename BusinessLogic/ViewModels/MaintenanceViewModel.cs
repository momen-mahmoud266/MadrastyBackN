using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class MaintenanceViewModel
    {
        public int MaintId { get; set; }
      
        public string MaintDate { get; set; } = string.Empty;

        public string MaintType { get; set; } = string.Empty;
       
        public string MaintLoc { get; set; } = string.Empty;
        public string MaintWork { get; set; } = string.Empty;
        public string MaintNotes { get; set; } = string.Empty;

    }
}
