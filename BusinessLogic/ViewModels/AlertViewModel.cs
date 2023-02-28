using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class AlertViewModel
    {
        public int Id { get; set; }
        public int LevelId { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public int AlertType { get; set; }
        public int IsSent { get; set; }
    }
}
