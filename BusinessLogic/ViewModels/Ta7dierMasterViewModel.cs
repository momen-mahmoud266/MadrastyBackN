using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Ta7dierMasterViewModel
    {
      
        public string EmpDep { get; set; } = string.Empty;
        public int Ta7dierId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public int GradeId { get; set; }
        public string GradeName { get; set; } = string.Empty;
        public string Ta7dierDate { get; set; } = string.Empty;
        public int Ta7dierWeek { get; set; }
        public int Ta7dierDay { get; set; }
        public int Ta7dierStateId { get; set; }
        public string StateName { get; set; } = string.Empty;
        public string Ta7dierName { get; set; } = string.Empty;
        public string Ta7dierBody { get; set; } = string.Empty;
        public string Ta7dierNotes { get; set; } = string.Empty;
        public int Ta7dierSupervisionStateId { get; set; }
        public string Ta7dierSupervisionStateName { get; set; } = string.Empty;
        public string Ta7dierStateName { get; set; } = string.Empty;
        public string Ta7dierFile { get; set; } = string.Empty;

        public string Ta7dierFileType { get; set; } = string.Empty;
        public int IsFile { get; set; } 
        public int DepId { get; set; } 
        public string Route { get; set; } = string.Empty;
        public int ToEmpId { get; set; }
    
   
    }
    }
