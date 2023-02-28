using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class MessagesViewModel
    {
       public string MsgId { get; set; } = string.Empty;
        public int FromEmpId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public int Reply { get; set; }
        public int ToEmpId { get; set; }
        public string Files { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Route { get; set; } = string.Empty;
        public int ObjectId { get; set; }
    }
}
