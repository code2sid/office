using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatePresentation.Factories
{
    public class BirthdayPresentation : IPresentation
    {
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Days { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Template { get; set; }

       

        public void OpenPresentation()
        {
            System.Diagnostics.Process.Start(Template);
        }

        public void GetData()
        {

        }
    }
}
