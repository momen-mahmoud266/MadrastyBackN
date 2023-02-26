using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class AdvertismentViewModel
    {
        public int AdvertimentId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public int FromEmployeeId { get; set; }
        public string SubmitDate { get; set; } = string.Empty;
        public int State { get; set; }
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
        public int IsPublic { get; set; }
        public int DepartmentId { get; set; }

    }
}
