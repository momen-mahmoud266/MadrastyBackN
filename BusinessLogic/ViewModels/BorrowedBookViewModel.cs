using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class BorrowedBookViewModel
    {
        public int Id { get; set; }
        public string Date { get; set; } = string.Empty;
        public string BookName { get; set; } = string.Empty;
        public string BorrowerName { get; set; } = string.Empty; 
    }
}
