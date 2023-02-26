using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class LibraryViewModel
    {
        public int LibraryId { get; set; }
        public int LibraryBook { get; set; }
        public int LibraryRefrence { get; set; }
        public string LibraryBookName { get; set; } = string.Empty;
        public string LibraryAuthorName { get; set; } = string.Empty;
        public string BookDate { get; set; } = string.Empty;
        public int BookPageNo { get; set; }
        public int LibraryRecordNo { get; set; }
        public string BookClassification { get; set; } = string.Empty;
    }
}
