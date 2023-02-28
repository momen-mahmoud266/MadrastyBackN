using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Site { get; set; } = string.Empty;
        public string Invitiees { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public string Objective { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


    }
}
