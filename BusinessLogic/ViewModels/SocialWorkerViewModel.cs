using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SocialWorkerViewModel
    {

        public int SocialId { get; set; }
        public string SocialLevel { get; set; } = string.Empty;
        public string SocialClass { get; set; } = string.Empty;
        public string SocialDep { get; set; } = string.Empty;
        public string SocialStudents { get; set; } = string.Empty;
        public string SocialDate { get; set; } = string.Empty;
        public string SocialReport { get; set; } = string.Empty;
        public string SocialManDep { get; set; } = string.Empty;
        public string SocialSuper { get; set; } = string.Empty;
        public string SocialWorkerOpin { get; set; } = string.Empty;
        public int CivilId { get; set; }

    }
}
