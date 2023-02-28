using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class NotificationViewModel
    {
        public int Id { get; set; }
        public string Route { get; set; } = string.Empty;
        public int FromPositionId { get; set; }
        public int ToPositionId { get; set; }
        public string MessageBody { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}
