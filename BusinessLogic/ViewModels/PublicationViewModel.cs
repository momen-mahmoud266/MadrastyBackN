using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class PublicationViewModel
    {
        public int Id { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Sender { get; set; } = string.Empty;
        public string Topic { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public int PagesNo { get; set; }
        public string Attach { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public int IsFile { get; set; }
        public int IsDepartment { get; set; }

    }
}
