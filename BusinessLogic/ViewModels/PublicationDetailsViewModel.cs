using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class PublicationDetailsViewModel
    {
        public int Id { get; set; }
        public int PublicationId { get; set; }
        public int ObjectId { get; set; }
        public string ObjectName { get; set; } = string.Empty;
    }
}
