using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class ParentsMeetingsViewModel
    {
        public int Id { get; set; }
        public string Date { get; set; } = string.Empty;
        public int LevelId { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string MeetingDate { get; set; } = string.Empty;
        public int MeetingSideId { get; set; }
        public string MeetingSideName { get; set; } = string.Empty;
    }
}
