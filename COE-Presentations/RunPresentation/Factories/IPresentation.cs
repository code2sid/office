using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatePresentation.Factories
{
    interface IPresentation
    {
         string Name { get; set; }
         string StartDate { get; set; }
         string EndDate { get; set; }
         string Days { get; set; }
         string StartTime { get; set; }
         string EndTime { get; set; }
         string Template { get; set; }

        void OpenPresentation();
        void GetData();
    }
}
