using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class MeetingTypeViewModel
    {
        public int MeetingTypeId { get; set; }
        public string MeetingTypeName { get; set; } = string.Empty;
        public int IsMeetingDate { get; set; }
        public string MeetingDate { get; set; } = string.Empty;
        public int IsGroupName { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public int IsStartTime { get; set; }
        public string StartTimeLabel { get; set; } = string.Empty;
        public int IsEndTime { get; set; }
        public string EndTimeLabel { get; set; } = string.Empty;
        public int IsGroupNumber { get; set; }
        public string GroupNumberLabel { get; set; } = string.Empty;
        public int IsMeetingMemNo { get; set; }
        public string MeetingMemNoLabel { get; set; } = string.Empty;
        public int IsMeetingLoc { get; set; }
        public string MeetingLocLabel { get; set; } = string.Empty;
        public int IsWorkPlan { get; set; }
        public string WorkPlanLabel { get; set; } = string.Empty;
        public int IsRecommendation { get; set; }
        public string RecommendationLabel { get; set; } = string.Empty;
        public int IsDep { get; set; }
        public string DepLabel { get; set; } = string.Empty;
        public int IsSubject { get; set; }
        public string SubjectLabel { get; set; } = string.Empty;
        public int IsAbscence { get; set; }
        public string AbscenceLabel { get; set; } = string.Empty;
        public int IsCourse { get; set; }
        public string CourseLabel { get; set; } = string.Empty;
        public int IsContent { get; set; }
        public string ContentLabel { get; set; } = string.Empty;
    }
}
