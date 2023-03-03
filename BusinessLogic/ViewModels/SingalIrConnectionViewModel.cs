using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SingalIrConnectionViewModel
    {
        public int Ser { get; set; }
        public string ConnectionId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public int FromEmpId { get; set; }
        public int ToEmpId { get; set; }
        public int JobId { get; set; }
        public int IsEmail { get; set; }
        public int ObjectId { get; set; }
        public string Route { get; set; } = string.Empty;
    }
}
